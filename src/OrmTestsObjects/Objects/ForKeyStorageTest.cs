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
    /// ForKeyStorageTest.
    /// </summary>
    // *** Start programmer edit section *** (ForKeyStorageTest CustomAttributes)

    // *** End programmer edit section *** (ForKeyStorageTest CustomAttributes)
    [PrimaryKeyStorage("StorageForKey")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class ForKeyStorageTest : ICSSoft.STORMNET.DataObject
    {
        
        private string fStorageForKey;
        
        // *** Start programmer edit section *** (ForKeyStorageTest CustomMembers)

        // *** End programmer edit section *** (ForKeyStorageTest CustomMembers)

        
        /// <summary>
        /// StorageForKey.
        /// </summary>
        // *** Start programmer edit section *** (ForKeyStorageTest.StorageForKey CustomAttributes)

        // *** End programmer edit section *** (ForKeyStorageTest.StorageForKey CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string StorageForKey
        {
            get
            {
                // *** Start programmer edit section *** (ForKeyStorageTest.StorageForKey Get start)

                // *** End programmer edit section *** (ForKeyStorageTest.StorageForKey Get start)
                string result = this.fStorageForKey;
                // *** Start programmer edit section *** (ForKeyStorageTest.StorageForKey Get end)

                // *** End programmer edit section *** (ForKeyStorageTest.StorageForKey Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ForKeyStorageTest.StorageForKey Set start)

                // *** End programmer edit section *** (ForKeyStorageTest.StorageForKey Set start)
                this.fStorageForKey = value;
                // *** Start programmer edit section *** (ForKeyStorageTest.StorageForKey Set end)

                // *** End programmer edit section *** (ForKeyStorageTest.StorageForKey Set end)
            }
        }
    }
}
