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
    /// Adress2.
    /// </summary>
    // *** Start programmer edit section *** (Adress2 CustomAttributes)

    // *** End programmer edit section *** (Adress2 CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Adress2E", new string[] {
            "HomeNumber as \'Home number\'",
            "Country as \'Country\'",
            "Country.CountryName as \'Country name\'"})]
    [View("Adress2L", new string[] {
            "HomeNumber as \'Home number\'",
            "Country.CountryName as \'Country name\'"})]
    public class Adress2 : ICSSoft.STORMNET.DataObject
    {
        
        private int fHomeNumber;
        
        private NewPlatform.OrmTestsObjects.Country2 fCountry;
        
        // *** Start programmer edit section *** (Adress2 CustomMembers)

        // *** End programmer edit section *** (Adress2 CustomMembers)

        
        /// <summary>
        /// HomeNumber.
        /// </summary>
        // *** Start programmer edit section *** (Adress2.HomeNumber CustomAttributes)

        // *** End programmer edit section *** (Adress2.HomeNumber CustomAttributes)
        public virtual int HomeNumber
        {
            get
            {
                // *** Start programmer edit section *** (Adress2.HomeNumber Get start)

                // *** End programmer edit section *** (Adress2.HomeNumber Get start)
                int result = this.fHomeNumber;
                // *** Start programmer edit section *** (Adress2.HomeNumber Get end)

                // *** End programmer edit section *** (Adress2.HomeNumber Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Adress2.HomeNumber Set start)

                // *** End programmer edit section *** (Adress2.HomeNumber Set start)
                this.fHomeNumber = value;
                // *** Start programmer edit section *** (Adress2.HomeNumber Set end)

                // *** End programmer edit section *** (Adress2.HomeNumber Set end)
            }
        }
        
        /// <summary>
        /// Adress2.
        /// </summary>
        // *** Start programmer edit section *** (Adress2.Country CustomAttributes)

        // *** End programmer edit section *** (Adress2.Country CustomAttributes)
        [NotNull()]
        public virtual NewPlatform.OrmTestsObjects.Country2 Country
        {
            get
            {
                // *** Start programmer edit section *** (Adress2.Country Get start)

                // *** End programmer edit section *** (Adress2.Country Get start)
                NewPlatform.OrmTestsObjects.Country2 result = this.fCountry;
                // *** Start programmer edit section *** (Adress2.Country Get end)

                // *** End programmer edit section *** (Adress2.Country Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Adress2.Country Set start)

                // *** End programmer edit section *** (Adress2.Country Set start)
                this.fCountry = value;
                // *** Start programmer edit section *** (Adress2.Country Set end)

                // *** End programmer edit section *** (Adress2.Country Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Adress2E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Adress2E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Adress2E", typeof(NewPlatform.OrmTestsObjects.Adress2));
                }
            }
            
            /// <summary>
            /// "Adress2L" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Adress2L
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Adress2L", typeof(NewPlatform.OrmTestsObjects.Adress2));
                }
            }
        }
    }
}
