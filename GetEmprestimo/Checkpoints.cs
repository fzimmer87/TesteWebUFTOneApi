//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Script
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using System.Collections.Generic;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.CheckpointFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Ext.CheckpointLogicOperators;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    
    
    public partial class WorkFlowScript
    {
        
        private void set_HTTPActivity4_checkpoints(STActivityBase activity)
        {
            // Checkpoint 1
            IVTDGetter actualValueGetter1 = new VTDObjectGetter(new VTDPropertyInfoBase("StatusCode"));
            IVTDSetter actualValueSetter1 = new VTDCheckpointSetter(XmlTypeCode.Int);
            BindDirection actualBindDirection1 = new BindDirection(_flow.HTTPActivity4, actualValueGetter1, actualValueSetter1);
            CpValObj valueActualObject1 = new CpValObj(actualBindDirection1, XmlTypeCode.Int, false);
            CpValObj valueExpectedObject1 = new CpValObj("200", XmlTypeCode.Int);
            ValueCPRule cpRule1 = new ValueCPRule(valueActualObject1, valueExpectedObject1, PrimitiveTypeCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule1);

            // Checkpoint 2
            IVTDGetter actualValueGetter2 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Object'][1]/*[local-name(.)='firstname'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter2 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection2 = new BindDirection(_flow.HTTPActivity4, actualValueGetter2, actualValueSetter2);
            CpValObj valueActualObject2 = new CpValObj(actualBindDirection2, XmlTypeCode.String, false);


            CpValObj valueExpectedObject2 = new CpValObj("{DataSource.excelGetEmprestimo!Emprestimo.FIRSTNAME}", bind_dir464);
            ValueCPRule cpRule2 = new ValueCPRule(valueActualObject2, valueExpectedObject2, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule2);

            // Checkpoint 3
            IVTDGetter actualValueGetter3 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Object'][1]/*[local-name(.)='lastname'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter3 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection3 = new BindDirection(_flow.HTTPActivity4, actualValueGetter3, actualValueSetter3);
            CpValObj valueActualObject3 = new CpValObj(actualBindDirection3, XmlTypeCode.String, false);


            CpValObj valueExpectedObject3 = new CpValObj("{DataSource.excelGetEmprestimo!Emprestimo.LASTNAME}", bind_dir465);
            ValueCPRule cpRule3 = new ValueCPRule(valueActualObject3, valueExpectedObject3, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule3);

            // Checkpoint 4
            IVTDGetter actualValueGetter4 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Object'][1]/*[local-name(.)='username'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter4 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection4 = new BindDirection(_flow.HTTPActivity4, actualValueGetter4, actualValueSetter4);
            CpValObj valueActualObject4 = new CpValObj(actualBindDirection4, XmlTypeCode.String, false);


            CpValObj valueExpectedObject4 = new CpValObj("{DataSource.excelGetEmprestimo!Emprestimo.USERNAME}", bind_dir466);
            ValueCPRule cpRule4 = new ValueCPRule(valueActualObject4, valueExpectedObject4, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule4);

            // Checkpoint 5
            IVTDGetter actualValueGetter5 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Object'][1]/*[local-name(.)='roles'][1]/*[local-name(.)='Value'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter5 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection5 = new BindDirection(_flow.HTTPActivity4, actualValueGetter5, actualValueSetter5);
            CpValObj valueActualObject5 = new CpValObj(actualBindDirection5, XmlTypeCode.String, false);
            CpValObj valueExpectedObject5 = new CpValObj("ROLE_USER", XmlTypeCode.String);
            ValueCPRule cpRule5 = new ValueCPRule(valueActualObject5, valueExpectedObject5, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule5);

        }
        
        private void set_HTTPActivity8_checkpoints(STActivityBase activity)
        {
            // Checkpoint 1
            IVTDGetter actualValueGetter1 = new VTDObjectGetter(new VTDPropertyInfoBase("StatusCode"));
            IVTDSetter actualValueSetter1 = new VTDCheckpointSetter(XmlTypeCode.Int);
            BindDirection actualBindDirection1 = new BindDirection(_flow.HTTPActivity8, actualValueGetter1, actualValueSetter1);
            CpValObj valueActualObject1 = new CpValObj(actualBindDirection1, XmlTypeCode.Int, false);
            CpValObj valueExpectedObject1 = new CpValObj("200", XmlTypeCode.Int);
            ValueCPRule cpRule1 = new ValueCPRule(valueActualObject1, valueExpectedObject1, PrimitiveTypeCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule1);

            // Checkpoint 2
            IVTDGetter actualValueGetter2 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Array'][1]/*[local-name(.)='Value'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter2 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection2 = new BindDirection(_flow.HTTPActivity8, actualValueGetter2, actualValueSetter2);
            CpValObj valueActualObject2 = new CpValObj(actualBindDirection2, XmlTypeCode.String, false);
            CpValObj valueExpectedObject2 = new CpValObj("status: accepted", XmlTypeCode.String);
            ValueCPRule cpRule2 = new ValueCPRule(valueActualObject2, valueExpectedObject2, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule2);

        }
        
        private void set_HTTPActivity7_checkpoints(STActivityBase activity)
        {
            // Checkpoint 1
            IVTDGetter actualValueGetter1 = new VTDObjectGetter(new VTDPropertyInfoBase("StatusCode"));
            IVTDSetter actualValueSetter1 = new VTDCheckpointSetter(XmlTypeCode.Int);
            BindDirection actualBindDirection1 = new BindDirection(_flow.HTTPActivity7, actualValueGetter1, actualValueSetter1);
            CpValObj valueActualObject1 = new CpValObj(actualBindDirection1, XmlTypeCode.Int, false);
            CpValObj valueExpectedObject1 = new CpValObj("200", XmlTypeCode.Int);
            ValueCPRule cpRule1 = new ValueCPRule(valueActualObject1, valueExpectedObject1, PrimitiveTypeCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule1);

            // Checkpoint 2
            IVTDGetter actualValueGetter2 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Array'][1]/*[local-name(.)='Object'][1]/*[local-name(.)='firstName'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter2 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection2 = new BindDirection(_flow.HTTPActivity7, actualValueGetter2, actualValueSetter2);
            CpValObj valueActualObject2 = new CpValObj(actualBindDirection2, XmlTypeCode.String, false);


            CpValObj valueExpectedObject2 = new CpValObj("{DataSource.excelGetEmprestimo!Emprestimo.FIRSTNAME}", bind_dir487);
            ValueCPRule cpRule2 = new ValueCPRule(valueActualObject2, valueExpectedObject2, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule2);

            // Checkpoint 3
            IVTDGetter actualValueGetter3 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Array'][1]/*[local-name(.)='Object'][1]/*[local-name(.)='lastName'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter3 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection3 = new BindDirection(_flow.HTTPActivity7, actualValueGetter3, actualValueSetter3);
            CpValObj valueActualObject3 = new CpValObj(actualBindDirection3, XmlTypeCode.String, false);


            CpValObj valueExpectedObject3 = new CpValObj("{DataSource.excelGetEmprestimo!Emprestimo.LASTNAME}", bind_dir488);
            ValueCPRule cpRule3 = new ValueCPRule(valueActualObject3, valueExpectedObject3, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule3);

            // Checkpoint 4
            IVTDGetter actualValueGetter4 = new VTDXPathGetter(new VTDPropertyInfoBase("XMLResponse", "/*[local-name(.)='Array'][1]/*[local-name(.)='Object'][1]/*[local-name(.)='username'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter4 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection4 = new BindDirection(_flow.HTTPActivity7, actualValueGetter4, actualValueSetter4);
            CpValObj valueActualObject4 = new CpValObj(actualBindDirection4, XmlTypeCode.String, false);


            CpValObj valueExpectedObject4 = new CpValObj("{DataSource.excelGetEmprestimo!Emprestimo.USERNAME}", bind_dir489);
            ValueCPRule cpRule4 = new ValueCPRule(valueActualObject4, valueExpectedObject4, StringCP.EqualTo, "=", false);
            activity.AddCheckpointRule(cpRule4);

        }
    }
}
