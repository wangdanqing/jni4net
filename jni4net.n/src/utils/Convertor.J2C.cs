﻿using System;
using java.lang;
using net.sf.jni4net.inj;
using net.sf.jni4net.jni;
using Boolean=java.lang.Boolean;
using Byte=java.lang.Byte;
using Double=java.lang.Double;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static Class J2CClass(JNIEnv env, IntPtr obj)
        {
            Class res = new Class(env);
            ((IJavaProxy)res).Init(env, obj, Class._class);
            return res;
        }

        public static String J2CString(JNIEnv env, IntPtr obj)
        {
            String res = new String(env);
            ((IJavaProxy)res).Init(env, obj, String._class);
            return res;
        }

        public static Object J2CObject(JNIEnv env, IntPtr obj)
        {
            Object res = new Object(env);
            ((IJavaProxy)res).Init(env, obj, Object._class);
            return res;
        }

        public static TRes J2C<TInput, TRes>(JNIEnv env, IntPtr obj)
        {
            return J2C<TRes>(env, obj);
        }

        public static TRes J2C<TRes>(JNIEnv env, IntPtr obj)
        {
            if (obj == IntPtr.Zero)
            {
                return default(TRes);
            }
            Type clrType = typeof(TRes);
            //TODO all sealed ?
            if (clrType == typeof(Class))
            {
                return (TRes)(object)J2CClass(env, obj);
            }
            if (clrType == typeof(String))
            {
                return (TRes)(object)J2CString(env, obj);
            }
            if (clrType == typeof(string))
            {
                return (TRes)(object)env.ConvertToString(obj);
            }
            if (typeof(IJavaProxy).IsAssignableFrom(clrType))
            {
                return (TRes)OptiJ2CP(env, obj, env.GetObjectClass(obj));
            }
            if (clrType.IsArray)
            {
                return (TRes)(object)J2CArray(env, obj, typeof(TRes).GetElementType());
            }
            Class clazz;
            clazz = env.GetObjectClass(obj);
            return (TRes)J2C(env, obj, clazz, clrType);
        }

        private static object J2C(JNIEnv env, IntPtr obj, Class clazz, Type type)
        {
            if (obj == IntPtr.Zero)
            {
                return null;
            }
            if (IClrProxy_._class.isAssignableFrom(clazz))
            {
                return OptiJP2C(env, obj);
            }
            if (clazz.isArray())
            {
                return J2CArray(env, obj, clazz);
            }
            IJavaProxy proxy = OptiJ2CP(env, obj, clazz);
            if (type.IsPrimitive)
            {
                if (type==typeof(bool))
                {
                    return ((Boolean) proxy).booleanValue();
                }
                if (type == typeof(char))
                {
                    return ((Character)proxy).charValue();
                }
                if (type == typeof(byte))
                {
                    return ((Byte)proxy).byteValue();
                }
                if (type == typeof(short))
                {
                    return ((Short)proxy).byteValue();
                }
                if (type == typeof(int))
                {
                    return ((Integer)proxy).byteValue();
                }
                if (type == typeof(long))
                {
                    return ((Long)proxy).byteValue();
                }
                if (type == typeof(double))
                {
                    return ((Double)proxy).byteValue();
                }
                if (type == typeof(float))
                {
                    return ((Float)proxy).byteValue();
                }
            }
            return proxy;
        }

        private static Array J2CArray(JNIEnv env, IntPtr array, Class arrayClazz)
        {
            Class elementClass = arrayClazz.getComponentType();
            Type elementType = Registry.Default.GetJVMRecord(elementClass).CLRInterface;
            return J2CArray(env, array, elementType);
        }

        private static Array J2CArray(JNIEnv env, IntPtr array, Type elementType)
        {
            int length = env.GetArrayLength(array);
            Array res = Array.CreateInstance(elementType, length);
            if (!elementType.IsPrimitive)
            {
                for (int i = 0; i < length; i++)
                {
                    IntPtr elementPtr = env.GetObjectArrayElementPtr(array, i);
                    Class elementClazz = env.GetObjectClass(elementPtr);
                    object element = J2C(env, elementPtr, elementClazz, elementType);
                    res.SetValue(element, i);
                }
            }
            else if (elementType == typeof(int))
            {
                env.GetIntArrayRegion(array, 0, length, (int[])res);
            }
            else if (elementType == typeof(char))
            {
                env.GetCharArrayRegion(array, 0, length, (char[])res);
            }
            else if (elementType == typeof(byte))
            {
                env.GetByteArrayRegion(array, 0, length, (byte[])res);
            }
            else if (elementType == typeof(long))
            {
                env.GetLongArrayRegion(array, 0, length, (long[])res);
            }
            else if (elementType == typeof(short))
            {
                env.GetShortArrayRegion(array, 0, length, (short[])res);
            }
            else if (elementType == typeof(double))
            {
                env.GetDoubleArrayRegion(array, 0, length, (double[])res);
            }
            else if (elementType == typeof(float))
            {
                env.GetFloatArrayRegion(array, 0, length, (float[])res);
            }
            else if (elementType == typeof(bool))
            {
                env.GetBooleanArrayRegion(array, 0, length, (bool[])res);
            }
            else
            {
                throw new NotImplementedException();
            }
            return res;
        }

        private static IJavaProxy OptiJ2CP(JNIEnv env, IntPtr obj, Class clazz)
        {
            RegistryRecord record = Registry.Default.GetRecord(env, obj, clazz);
            IJavaProxy proxy = record.CLRConstructor.CreateProxy(env);
            proxy.Init(env, obj, clazz);
            return proxy;
        }

        private static object OptiJP2C(JNIEnv env, IntPtr obj)
        {
            int handle = __IClrProxy.getClrHandle(env, obj);
            return IntHandle.ToObject(handle);
        }

    }
}