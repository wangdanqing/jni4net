//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util.zip {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ZipEntry : global::java.lang.Object, global::java.lang.Cloneable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _clone0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMethod2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSize3;
        
        internal static global::net.sf.jni4net.jni.MethodId _setSize4;
        
        internal static global::net.sf.jni4net.jni.MethodId _isDirectory5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getComment6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCompressedSize7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCrc8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getExtra9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTime10;
        
        internal static global::net.sf.jni4net.jni.MethodId _setComment11;
        
        internal static global::net.sf.jni4net.jni.MethodId _setCompressedSize12;
        
        internal static global::net.sf.jni4net.jni.MethodId _setCrc13;
        
        internal static global::net.sf.jni4net.jni.MethodId _setExtra14;
        
        internal static global::net.sf.jni4net.jni.MethodId _setMethod15;
        
        internal static global::net.sf.jni4net.jni.MethodId _setTime16;
        
        internal static global::net.sf.jni4net.jni.FieldId _STORED17;
        
        internal static global::net.sf.jni4net.jni.FieldId _DEFLATED18;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCSIG19;
        
        internal static global::net.sf.jni4net.jni.FieldId _EXTSIG20;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENSIG21;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENDSIG22;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCHDR23;
        
        internal static global::net.sf.jni4net.jni.FieldId _EXTHDR24;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENHDR25;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENDHDR26;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCVER27;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCFLG28;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCHOW29;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCTIM30;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCCRC31;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCSIZ32;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCLEN33;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCNAM34;
        
        internal static global::net.sf.jni4net.jni.FieldId _LOCEXT35;
        
        internal static global::net.sf.jni4net.jni.FieldId _EXTCRC36;
        
        internal static global::net.sf.jni4net.jni.FieldId _EXTSIZ37;
        
        internal static global::net.sf.jni4net.jni.FieldId _EXTLEN38;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENVEM39;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENVER40;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENFLG41;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENHOW42;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENTIM43;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENCRC44;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENSIZ45;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENLEN46;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENNAM47;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENEXT48;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENCOM49;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENDSK50;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENATT51;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENATX52;
        
        internal static global::net.sf.jni4net.jni.FieldId _CENOFF53;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENDSUB54;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENDTOT55;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENDSIZ56;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENDOFF57;
        
        internal static global::net.sf.jni4net.jni.FieldId _ENDCOM58;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor59;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor60;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/zip/ZipEntry;)V")]
        public ZipEntry(global::java.util.zip.ZipEntry par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry.@__ctor59, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public ZipEntry(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry.@__ctor60, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        protected ZipEntry(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.zip.ZipEntry.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int STORED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._STORED17)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DEFLATED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._DEFLATED18)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public static long LOCSIG {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((long)(@__env.GetStaticLongField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCSIG19)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public static long EXTSIG {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((long)(@__env.GetStaticLongField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._EXTSIG20)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public static long CENSIG {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((long)(@__env.GetStaticLongField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENSIG21)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public static long ENDSIG {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((long)(@__env.GetStaticLongField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ENDSIG22)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCHDR {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCHDR23)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int EXTHDR {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._EXTHDR24)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENHDR {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENHDR25)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ENDHDR {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ENDHDR26)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCVER {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCVER27)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCFLG {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCFLG28)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCHOW {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCHOW29)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCTIM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCTIM30)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCCRC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCCRC31)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCSIZ {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCSIZ32)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCLEN {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCLEN33)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCNAM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCNAM34)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int LOCEXT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._LOCEXT35)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int EXTCRC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._EXTCRC36)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int EXTSIZ {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._EXTSIZ37)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int EXTLEN {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._EXTLEN38)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENVEM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENVEM39)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENVER {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENVER40)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENFLG {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENFLG41)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENHOW {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENHOW42)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENTIM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENTIM43)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENCRC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENCRC44)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENSIZ {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENSIZ45)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENLEN {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENLEN46)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENNAM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENNAM47)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENEXT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENEXT48)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENCOM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENCOM49)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENDSK {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENDSK50)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENATT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENATT51)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENATX {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENATX52)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int CENOFF {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._CENOFF53)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ENDSUB {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ENDSUB54)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ENDTOT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ENDTOT55)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ENDSIZ {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ENDSIZ56)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ENDOFF {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ENDOFF57)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ENDCOM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ENDCOM58)));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.zip.ZipEntry.staticClass = @__class;
            global::java.util.zip.ZipEntry._clone0 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "clone", "()Ljava/lang/Object;");
            global::java.util.zip.ZipEntry._getName1 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getName", "()Ljava/lang/String;");
            global::java.util.zip.ZipEntry._getMethod2 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getMethod", "()I");
            global::java.util.zip.ZipEntry._getSize3 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getSize", "()J");
            global::java.util.zip.ZipEntry._setSize4 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "setSize", "(J)V");
            global::java.util.zip.ZipEntry._isDirectory5 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "isDirectory", "()Z");
            global::java.util.zip.ZipEntry._getComment6 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getComment", "()Ljava/lang/String;");
            global::java.util.zip.ZipEntry._getCompressedSize7 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getCompressedSize", "()J");
            global::java.util.zip.ZipEntry._getCrc8 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getCrc", "()J");
            global::java.util.zip.ZipEntry._getExtra9 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getExtra", "()[B");
            global::java.util.zip.ZipEntry._getTime10 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "getTime", "()J");
            global::java.util.zip.ZipEntry._setComment11 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "setComment", "(Ljava/lang/String;)V");
            global::java.util.zip.ZipEntry._setCompressedSize12 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "setCompressedSize", "(J)V");
            global::java.util.zip.ZipEntry._setCrc13 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "setCrc", "(J)V");
            global::java.util.zip.ZipEntry._setExtra14 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "setExtra", "([B)V");
            global::java.util.zip.ZipEntry._setMethod15 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "setMethod", "(I)V");
            global::java.util.zip.ZipEntry._setTime16 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "setTime", "(J)V");
            global::java.util.zip.ZipEntry._STORED17 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "STORED", "I");
            global::java.util.zip.ZipEntry._DEFLATED18 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "DEFLATED", "I");
            global::java.util.zip.ZipEntry._LOCSIG19 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCSIG", "J");
            global::java.util.zip.ZipEntry._EXTSIG20 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "EXTSIG", "J");
            global::java.util.zip.ZipEntry._CENSIG21 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENSIG", "J");
            global::java.util.zip.ZipEntry._ENDSIG22 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "ENDSIG", "J");
            global::java.util.zip.ZipEntry._LOCHDR23 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCHDR", "I");
            global::java.util.zip.ZipEntry._EXTHDR24 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "EXTHDR", "I");
            global::java.util.zip.ZipEntry._CENHDR25 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENHDR", "I");
            global::java.util.zip.ZipEntry._ENDHDR26 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "ENDHDR", "I");
            global::java.util.zip.ZipEntry._LOCVER27 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCVER", "I");
            global::java.util.zip.ZipEntry._LOCFLG28 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCFLG", "I");
            global::java.util.zip.ZipEntry._LOCHOW29 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCHOW", "I");
            global::java.util.zip.ZipEntry._LOCTIM30 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCTIM", "I");
            global::java.util.zip.ZipEntry._LOCCRC31 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCCRC", "I");
            global::java.util.zip.ZipEntry._LOCSIZ32 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCSIZ", "I");
            global::java.util.zip.ZipEntry._LOCLEN33 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCLEN", "I");
            global::java.util.zip.ZipEntry._LOCNAM34 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCNAM", "I");
            global::java.util.zip.ZipEntry._LOCEXT35 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "LOCEXT", "I");
            global::java.util.zip.ZipEntry._EXTCRC36 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "EXTCRC", "I");
            global::java.util.zip.ZipEntry._EXTSIZ37 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "EXTSIZ", "I");
            global::java.util.zip.ZipEntry._EXTLEN38 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "EXTLEN", "I");
            global::java.util.zip.ZipEntry._CENVEM39 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENVEM", "I");
            global::java.util.zip.ZipEntry._CENVER40 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENVER", "I");
            global::java.util.zip.ZipEntry._CENFLG41 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENFLG", "I");
            global::java.util.zip.ZipEntry._CENHOW42 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENHOW", "I");
            global::java.util.zip.ZipEntry._CENTIM43 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENTIM", "I");
            global::java.util.zip.ZipEntry._CENCRC44 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENCRC", "I");
            global::java.util.zip.ZipEntry._CENSIZ45 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENSIZ", "I");
            global::java.util.zip.ZipEntry._CENLEN46 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENLEN", "I");
            global::java.util.zip.ZipEntry._CENNAM47 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENNAM", "I");
            global::java.util.zip.ZipEntry._CENEXT48 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENEXT", "I");
            global::java.util.zip.ZipEntry._CENCOM49 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENCOM", "I");
            global::java.util.zip.ZipEntry._CENDSK50 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENDSK", "I");
            global::java.util.zip.ZipEntry._CENATT51 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENATT", "I");
            global::java.util.zip.ZipEntry._CENATX52 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENATX", "I");
            global::java.util.zip.ZipEntry._CENOFF53 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "CENOFF", "I");
            global::java.util.zip.ZipEntry._ENDSUB54 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "ENDSUB", "I");
            global::java.util.zip.ZipEntry._ENDTOT55 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "ENDTOT", "I");
            global::java.util.zip.ZipEntry._ENDSIZ56 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "ENDSIZ", "I");
            global::java.util.zip.ZipEntry._ENDOFF57 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "ENDOFF", "I");
            global::java.util.zip.ZipEntry._ENDCOM58 = @__env.GetStaticFieldID(global::java.util.zip.ZipEntry.staticClass, "ENDCOM", "I");
            global::java.util.zip.ZipEntry.@__ctor59 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
            global::java.util.zip.ZipEntry.@__ctor60 = @__env.GetMethodID(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        public virtual global::java.lang.Object clone() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.zip.ZipEntry._clone0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.util.zip.ZipEntry._getName1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getMethod() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.util.zip.ZipEntry._getMethod2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getSize() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.util.zip.ZipEntry._getSize3)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public virtual void setSize(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.zip.ZipEntry._setSize4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isDirectory() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.zip.ZipEntry._isDirectory5)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getComment() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.util.zip.ZipEntry._getComment6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getCompressedSize() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.util.zip.ZipEntry._getCompressedSize7)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getCrc() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.util.zip.ZipEntry._getCrc8)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[B")]
        public virtual byte[] getExtra() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, @__env.CallObjectMethodPtr(this, global::java.util.zip.ZipEntry._getExtra9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getTime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.util.zip.ZipEntry._getTime10)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public virtual void setComment(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.zip.ZipEntry._setComment11, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public virtual void setCompressedSize(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.zip.ZipEntry._setCompressedSize12, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public virtual void setCrc(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.zip.ZipEntry._setCrc13, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)V")]
        public virtual void setExtra(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.zip.ZipEntry._setExtra14, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void setMethod(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.zip.ZipEntry._setMethod15, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public virtual void setTime(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.zip.ZipEntry._setTime16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.zip.ZipEntry(@__env);
            }
        }
    }
    #endregion
}