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
    /// МастерМ.
    /// </summary>
    // *** Start programmer edit section *** (МастерМ CustomAttributes)

    // *** End programmer edit section *** (МастерМ CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class МастерМ : ICSSoft.STORMNET.DataObject
    {
        
        // *** Start programmer edit section *** (МастерМ CustomMembers)

        // *** End programmer edit section *** (МастерМ CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (МастерМ.Name CustomAttributes)

        // *** End programmer edit section *** (МастерМ.Name CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (МастерМ.Name Get)

                return null;
                // *** End programmer edit section *** (МастерМ.Name Get)
            }
            set
            {
                // *** Start programmer edit section *** (МастерМ.Name Set)

                // *** End programmer edit section *** (МастерМ.Name Set)
            }
        }
        
        /// <summary>
        /// Value.
        /// </summary>
        // *** Start programmer edit section *** (МастерМ.Value CustomAttributes)

        // *** End programmer edit section *** (МастерМ.Value CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual int Value
        {
            get
            {
                // *** Start programmer edit section *** (МастерМ.Value Get)

                return 0;
                // *** End programmer edit section *** (МастерМ.Value Get)
            }
            set
            {
                // *** Start programmer edit section *** (МастерМ.Value Set)

                // *** End programmer edit section *** (МастерМ.Value Set)
            }
        }
    }
}
