//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class JWithClrInterface : global::java.lang.Object, global::System.IComparable, global::java.lang.Runnable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _CompareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _run1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getValue2;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass4;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait5;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait6;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait7;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals8;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify9;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll10;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString11;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor12;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public JWithClrInterface(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, global::net.sf.jni4net.tested.JWithClrInterface.@__ctor12, this, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        protected JWithClrInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JWithClrInterface.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.JWithClrInterface.staticClass = @__class;
            global::net.sf.jni4net.tested.JWithClrInterface._CompareTo0 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "CompareTo", "(Lsystem/Object;)I");
            global::net.sf.jni4net.tested.JWithClrInterface._run1 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "run", "()V");
            global::net.sf.jni4net.tested.JWithClrInterface._getValue2 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "getValue", "()I");
            global::net.sf.jni4net.tested.JWithClrInterface._hashCode3 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "hashCode", "()I");
            global::net.sf.jni4net.tested.JWithClrInterface._getClass4 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "getClass", "()Ljava/lang/Class;");
            global::net.sf.jni4net.tested.JWithClrInterface._wait5 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "wait", "()V");
            global::net.sf.jni4net.tested.JWithClrInterface._wait6 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "wait", "(JI)V");
            global::net.sf.jni4net.tested.JWithClrInterface._wait7 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "wait", "(J)V");
            global::net.sf.jni4net.tested.JWithClrInterface._equals8 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::net.sf.jni4net.tested.JWithClrInterface._notify9 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "notify", "()V");
            global::net.sf.jni4net.tested.JWithClrInterface._notifyAll10 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "notifyAll", "()V");
            global::net.sf.jni4net.tested.JWithClrInterface._toString11 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "toString", "()Ljava/lang/String;");
            global::net.sf.jni4net.tested.JWithClrInterface.@__ctor12 = @__env.GetMethodID(global::net.sf.jni4net.tested.JWithClrInterface.staticClass, "<init>", "(I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(LSystem/Object;)I")]
        public virtual int CompareTo(object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._CompareTo0, global::net.sf.jni4net.utils.Convertor.ParamC2J<object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void run() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._run1);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._getValue2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._hashCode3)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JWithClrInterface._getClass4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._wait5);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._wait6, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._wait7, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._equals8, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._notify9);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JWithClrInterface._notifyAll10);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JWithClrInterface._toString11));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.JWithClrInterface(@__env);
            }
        }
    }
    #endregion
}
