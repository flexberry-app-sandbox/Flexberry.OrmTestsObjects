//------------------------------------------------------------------------------
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
    /// CombinedTypesUsageProviderTestClass.
    /// </summary>
    // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass CustomAttributes)

    // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass CustomAttributes)
    [ClassStorage("CombinedTypesUsageProviderTest")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class CombinedTypesUsageProviderTestClass : NewPlatform.OrmTestsObjects.TypeNameUsageProviderTestClass
    {
        
        private NewPlatform.OrmTestsObjects.DataObjectForTest fDataObjectForTest;
        
        private NewPlatform.OrmTestsObjects.TypeUsageProviderTestClass fTypeUsageProviderTestClass;
        
        // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass CustomMembers)

        // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass CustomMembers)

        
        /// <summary>
        /// CombinedTypesUsageProviderTestClass.
        /// </summary>
        // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest CustomAttributes)

        // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest CustomAttributes)
        public virtual NewPlatform.OrmTestsObjects.DataObjectForTest DataObjectForTest
        {
            get
            {
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Get start)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Get start)
                NewPlatform.OrmTestsObjects.DataObjectForTest result = this.fDataObjectForTest;
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Get end)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Set start)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Set start)
                this.fDataObjectForTest = value;
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Set end)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.DataObjectForTest Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.OrmTestsObjects.TypeUsageProviderTestClass.
        /// </summary>
        // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass CustomAttributes)

        // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "TypeUsageProviderTestClass"})]
        public virtual NewPlatform.OrmTestsObjects.TypeUsageProviderTestClass TypeUsageProviderTestClass
        {
            get
            {
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Get start)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Get start)
                NewPlatform.OrmTestsObjects.TypeUsageProviderTestClass result = this.fTypeUsageProviderTestClass;
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Get end)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Set start)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Set start)
                this.fTypeUsageProviderTestClass = value;
                // *** Start programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Set end)

                // *** End programmer edit section *** (CombinedTypesUsageProviderTestClass.TypeUsageProviderTestClass Set end)
            }
        }
    }
    
    /// <summary>
    /// Detail array of CombinedTypesUsageProviderTestClass.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfCombinedTypesUsageProviderTestClass CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfCombinedTypesUsageProviderTestClass CustomAttributes)
    public class DetailArrayOfCombinedTypesUsageProviderTestClass : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.OrmTestsObjects.DetailArrayOfCombinedTypesUsageProviderTestClass members)

        // *** End programmer edit section *** (NewPlatform.OrmTestsObjects.DetailArrayOfCombinedTypesUsageProviderTestClass members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type CombinedTypesUsageProviderTestClass by index.
        /// </summary>
        /// <summary>
        /// Adds object with type CombinedTypesUsageProviderTestClass.
        /// </summary>
        public DetailArrayOfCombinedTypesUsageProviderTestClass(NewPlatform.OrmTestsObjects.TypeUsageProviderTestClass fTypeUsageProviderTestClass) : 
                base(typeof(CombinedTypesUsageProviderTestClass), ((ICSSoft.STORMNET.DataObject)(fTypeUsageProviderTestClass)))
        {
        }
        
        public NewPlatform.OrmTestsObjects.CombinedTypesUsageProviderTestClass this[int index]
        {
            get
            {
                return ((NewPlatform.OrmTestsObjects.CombinedTypesUsageProviderTestClass)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.OrmTestsObjects.CombinedTypesUsageProviderTestClass dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
