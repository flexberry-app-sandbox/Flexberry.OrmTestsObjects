﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.OrmTestsObjects
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// InformationTestClass6.
    /// </summary>
    // *** Start programmer edit section *** (InformationTestClass6 CustomAttributes)

    // *** End programmer edit section *** (InformationTestClass6 CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class InformationTestClass6 : ICSSoft.STORMNET.DataObject
    {
        
        private string fStringPropertyForInformationTestClass6;
        
        private NewPlatform.OrmTestsObjects.ClassWithCaptions fExampleOfClassWithCaptions;
        
        // *** Start programmer edit section *** (InformationTestClass6 CustomMembers)

        // *** End programmer edit section *** (InformationTestClass6 CustomMembers)

        
        /// <summary>
        /// StringPropertyForInformationTestClass6.
        /// </summary>
        // *** Start programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 CustomAttributes)

        // *** End programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 CustomAttributes)
        [PropertyStorage("StringPropForInfTestClass6")]
        [StrLen(255)]
        public virtual string StringPropertyForInformationTestClass6
        {
            get
            {
                // *** Start programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Get start)

                // *** End programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Get start)
                string result = this.fStringPropertyForInformationTestClass6;
                // *** Start programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Get end)

                // *** End programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Set start)

                // *** End programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Set start)
                this.fStringPropertyForInformationTestClass6 = value;
                // *** Start programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Set end)

                // *** End programmer edit section *** (InformationTestClass6.StringPropertyForInformationTestClass6 Set end)
            }
        }
        
        /// <summary>
        /// InformationTestClass6.
        /// </summary>
        // *** Start programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions CustomAttributes)

        // *** End programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions CustomAttributes)
        [PropertyStorage(new string[] {
                "ExampleOfClassWithCaptions"})]
        [NotNull()]
        public virtual NewPlatform.OrmTestsObjects.ClassWithCaptions ExampleOfClassWithCaptions
        {
            get
            {
                // *** Start programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Get start)

                // *** End programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Get start)
                NewPlatform.OrmTestsObjects.ClassWithCaptions result = this.fExampleOfClassWithCaptions;
                // *** Start programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Get end)

                // *** End programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Set start)

                // *** End programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Set start)
                this.fExampleOfClassWithCaptions = value;
                // *** Start programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Set end)

                // *** End programmer edit section *** (InformationTestClass6.ExampleOfClassWithCaptions Set end)
            }
        }
    }
}