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
    /// TypeUsageProviderTestClass.
    /// </summary>
    // *** Start programmer edit section *** (TypeUsageProviderTestClass CustomAttributes)

    // *** End programmer edit section *** (TypeUsageProviderTestClass CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class TypeUsageProviderTestClass : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private NewPlatform.OrmTestsObjects.DataObjectForTest fDataObjectForTest;
        
        private NewPlatform.OrmTestsObjects.DetailArrayOfCombinedTypesUsageProviderTestClass fCombinedTypesUsageProviderTestClass;
        
        // *** Start programmer edit section *** (TypeUsageProviderTestClass CustomMembers)

        // *** End programmer edit section *** (TypeUsageProviderTestClass CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Get start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Get end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Set start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Set end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Set end)
            }
        }
        
        /// <summary>
        /// SomeNotStoredObjectProperty.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual object SomeNotStoredObjectProperty
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Get)

                return null;
                // *** End programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Get)
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Set)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Set)
            }
        }
        
        /// <summary>
        /// TypeUsageProviderTestClass.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest CustomAttributes)
        public virtual NewPlatform.OrmTestsObjects.DataObjectForTest DataObjectForTest
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get start)
                NewPlatform.OrmTestsObjects.DataObjectForTest result = this.fDataObjectForTest;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set start)
                this.fDataObjectForTest = value;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set end)
            }
        }
        
        /// <summary>
        /// TypeUsageProviderTestClass.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass CustomAttributes)
        public virtual NewPlatform.OrmTestsObjects.DetailArrayOfCombinedTypesUsageProviderTestClass CombinedTypesUsageProviderTestClass
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get start)
                if ((this.fCombinedTypesUsageProviderTestClass == null))
                {
                    this.fCombinedTypesUsageProviderTestClass = new NewPlatform.OrmTestsObjects.DetailArrayOfCombinedTypesUsageProviderTestClass(this);
                }
                NewPlatform.OrmTestsObjects.DetailArrayOfCombinedTypesUsageProviderTestClass result = this.fCombinedTypesUsageProviderTestClass;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set start)
                this.fCombinedTypesUsageProviderTestClass = value;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set end)
            }
        }
    }
}
