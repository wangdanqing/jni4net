// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.runtime.rule;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ConsequenceExceptionHandler_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.runtime.rule.ConsequenceExceptionHandler_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.runtime.rule.ConsequenceExceptionHandler_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ConsequenceExceptionHandler extends system.Object implements org.drools.runtime.rule.ConsequenceExceptionHandler {
    
    protected __ConsequenceExceptionHandler(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/runtime/rule/Activation;Lorg/drools/runtime/rule/WorkingMemory;Ljava/lang/Exception;)V")
    public native void handleException(org.drools.runtime.rule.Activation par0, org.drools.runtime.rule.WorkingMemory par1, java.lang.Exception par2);
}
//</generated-proxy>