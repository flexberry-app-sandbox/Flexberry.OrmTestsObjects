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
    /// ОценкаЭксперта.
    /// </summary>
    // *** Start programmer edit section *** (ОценкаЭксперта CustomAttributes)

    // *** End programmer edit section *** (ОценкаЭксперта CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОценкаЭкспертаE", new string[] {
            "ЗначениеОценки",
            "Комментарий",
            "ЗначениеКритерия",
            "Эксперт"})]
    public class ОценкаЭксперта : ICSSoft.STORMNET.DataObject
    {
        
        private double fЗначениеОценки;
        
        private string fКомментарий;
        
        private NewPlatform.OrmTestsObjects.ЗначениеКритерия fЗначениеКритерия;
        
        private NewPlatform.OrmTestsObjects.Пользователь fЭксперт;
        
        private NewPlatform.OrmTestsObjects.Идея fИдея;
        
        // *** Start programmer edit section *** (ОценкаЭксперта CustomMembers)

        // *** End programmer edit section *** (ОценкаЭксперта CustomMembers)

        
        /// <summary>
        /// ЗначениеОценки.
        /// </summary>
        // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеОценки CustomAttributes)

        // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеОценки CustomAttributes)
        public virtual double ЗначениеОценки
        {
            get
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Get start)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Get start)
                double result = this.fЗначениеОценки;
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Get end)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Set start)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Set start)
                this.fЗначениеОценки = value;
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Set end)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеОценки Set end)
            }
        }
        
        /// <summary>
        /// Комментарий.
        /// </summary>
        // *** Start programmer edit section *** (ОценкаЭксперта.Комментарий CustomAttributes)

        // *** End programmer edit section *** (ОценкаЭксперта.Комментарий CustomAttributes)
        [StrLen(255)]
        public virtual string Комментарий
        {
            get
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.Комментарий Get start)

                // *** End programmer edit section *** (ОценкаЭксперта.Комментарий Get start)
                string result = this.fКомментарий;
                // *** Start programmer edit section *** (ОценкаЭксперта.Комментарий Get end)

                // *** End programmer edit section *** (ОценкаЭксперта.Комментарий Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.Комментарий Set start)

                // *** End programmer edit section *** (ОценкаЭксперта.Комментарий Set start)
                this.fКомментарий = value;
                // *** Start programmer edit section *** (ОценкаЭксперта.Комментарий Set end)

                // *** End programmer edit section *** (ОценкаЭксперта.Комментарий Set end)
            }
        }
        
        /// <summary>
        /// ОценкаЭксперта.
        /// </summary>
        // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия CustomAttributes)

        // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия CustomAttributes)
        [PropertyStorage(new string[] {
                "ЗначениеКритер"})]
        [NotNull()]
        public virtual NewPlatform.OrmTestsObjects.ЗначениеКритерия ЗначениеКритерия
        {
            get
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Get start)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Get start)
                NewPlatform.OrmTestsObjects.ЗначениеКритерия result = this.fЗначениеКритерия;
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Get end)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Set start)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Set start)
                this.fЗначениеКритерия = value;
                // *** Start programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Set end)

                // *** End programmer edit section *** (ОценкаЭксперта.ЗначениеКритерия Set end)
            }
        }
        
        /// <summary>
        /// ОценкаЭксперта.
        /// </summary>
        // *** Start programmer edit section *** (ОценкаЭксперта.Эксперт CustomAttributes)

        // *** End programmer edit section *** (ОценкаЭксперта.Эксперт CustomAttributes)
        [NotNull()]
        public virtual NewPlatform.OrmTestsObjects.Пользователь Эксперт
        {
            get
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.Эксперт Get start)

                // *** End programmer edit section *** (ОценкаЭксперта.Эксперт Get start)
                NewPlatform.OrmTestsObjects.Пользователь result = this.fЭксперт;
                // *** Start programmer edit section *** (ОценкаЭксперта.Эксперт Get end)

                // *** End programmer edit section *** (ОценкаЭксперта.Эксперт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.Эксперт Set start)

                // *** End programmer edit section *** (ОценкаЭксперта.Эксперт Set start)
                this.fЭксперт = value;
                // *** Start programmer edit section *** (ОценкаЭксперта.Эксперт Set end)

                // *** End programmer edit section *** (ОценкаЭксперта.Эксперт Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.OrmTestsObjects.Идея.
        /// </summary>
        // *** Start programmer edit section *** (ОценкаЭксперта.Идея CustomAttributes)

        // *** End programmer edit section *** (ОценкаЭксперта.Идея CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual NewPlatform.OrmTestsObjects.Идея Идея
        {
            get
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.Идея Get start)

                // *** End programmer edit section *** (ОценкаЭксперта.Идея Get start)
                NewPlatform.OrmTestsObjects.Идея result = this.fИдея;
                // *** Start programmer edit section *** (ОценкаЭксперта.Идея Get end)

                // *** End programmer edit section *** (ОценкаЭксперта.Идея Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОценкаЭксперта.Идея Set start)

                // *** End programmer edit section *** (ОценкаЭксперта.Идея Set start)
                this.fИдея = value;
                // *** Start programmer edit section *** (ОценкаЭксперта.Идея Set end)

                // *** End programmer edit section *** (ОценкаЭксперта.Идея Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОценкаЭкспертаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОценкаЭкспертаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОценкаЭкспертаE", typeof(NewPlatform.OrmTestsObjects.ОценкаЭксперта));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ОценкаЭксперта.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfОценкаЭксперта CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfОценкаЭксперта CustomAttributes)
    public class DetailArrayOfОценкаЭксперта : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.OrmTestsObjects.DetailArrayOfОценкаЭксперта members)

        // *** End programmer edit section *** (NewPlatform.OrmTestsObjects.DetailArrayOfОценкаЭксперта members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ОценкаЭксперта by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ОценкаЭксперта.
        /// </summary>
        public DetailArrayOfОценкаЭксперта(NewPlatform.OrmTestsObjects.Идея fИдея) : 
                base(typeof(ОценкаЭксперта), ((ICSSoft.STORMNET.DataObject)(fИдея)))
        {
        }
        
        public NewPlatform.OrmTestsObjects.ОценкаЭксперта this[int index]
        {
            get
            {
                return ((NewPlatform.OrmTestsObjects.ОценкаЭксперта)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.OrmTestsObjects.ОценкаЭксперта dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
