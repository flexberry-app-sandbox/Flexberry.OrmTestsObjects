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
    /// Идея.
    /// </summary>
    // *** Start programmer edit section *** (Идея CustomAttributes)

    // *** End programmer edit section *** (Идея CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ИдеяE", new string[] {
            "Заголовок",
            "Описание",
            "СуммаБаллов",
            "Конкурс",
            "Автор"})]
    [AssociatedDetailViewAttribute("ИдеяE", "ЗначенияКритериев", "ЗначениеКритерияE", true, "", "", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("ИдеяE", "ОценкиЭкспертов", "ОценкаЭкспертаE", true, "", "", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("ИдеяE", "Файлы", "ФайлE", true, "", "", true, new string[] {
            ""})]
    public class Идея : ICSSoft.STORMNET.DataObject
    {
        
        private string fЗаголовок;
        
        private string fОписание;
        
        private double fСуммаБаллов;
        
        private NewPlatform.OrmTestsObjects.Пользователь fАвтор;
        
        private NewPlatform.OrmTestsObjects.Конкурс fКонкурс;
        
        private NewPlatform.OrmTestsObjects.DetailArrayOfЗначениеКритерия fЗначенияКритериев;
        
        private NewPlatform.OrmTestsObjects.DetailArrayOfОценкаЭксперта fОценкиЭкспертов;
        
        private NewPlatform.OrmTestsObjects.DetailArrayOfФайлИдеи fФайлы;
        
        // *** Start programmer edit section *** (Идея CustomMembers)

        // *** End programmer edit section *** (Идея CustomMembers)

        
        /// <summary>
        /// Заголовок.
        /// </summary>
        // *** Start programmer edit section *** (Идея.Заголовок CustomAttributes)

        // *** End programmer edit section *** (Идея.Заголовок CustomAttributes)
        [StrLen(255)]
        public virtual string Заголовок
        {
            get
            {
                // *** Start programmer edit section *** (Идея.Заголовок Get start)

                // *** End programmer edit section *** (Идея.Заголовок Get start)
                string result = this.fЗаголовок;
                // *** Start programmer edit section *** (Идея.Заголовок Get end)

                // *** End programmer edit section *** (Идея.Заголовок Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.Заголовок Set start)

                // *** End programmer edit section *** (Идея.Заголовок Set start)
                this.fЗаголовок = value;
                // *** Start programmer edit section *** (Идея.Заголовок Set end)

                // *** End programmer edit section *** (Идея.Заголовок Set end)
            }
        }
        
        /// <summary>
        /// Описание.
        /// </summary>
        // *** Start programmer edit section *** (Идея.Описание CustomAttributes)

        // *** End programmer edit section *** (Идея.Описание CustomAttributes)
        [StrLen(255)]
        public virtual string Описание
        {
            get
            {
                // *** Start programmer edit section *** (Идея.Описание Get start)

                // *** End programmer edit section *** (Идея.Описание Get start)
                string result = this.fОписание;
                // *** Start programmer edit section *** (Идея.Описание Get end)

                // *** End programmer edit section *** (Идея.Описание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.Описание Set start)

                // *** End programmer edit section *** (Идея.Описание Set start)
                this.fОписание = value;
                // *** Start programmer edit section *** (Идея.Описание Set end)

                // *** End programmer edit section *** (Идея.Описание Set end)
            }
        }
        
        /// <summary>
        /// СуммаБаллов.
        /// </summary>
        // *** Start programmer edit section *** (Идея.СуммаБаллов CustomAttributes)

        // *** End programmer edit section *** (Идея.СуммаБаллов CustomAttributes)
        public virtual double СуммаБаллов
        {
            get
            {
                // *** Start programmer edit section *** (Идея.СуммаБаллов Get start)

                // *** End programmer edit section *** (Идея.СуммаБаллов Get start)
                double result = this.fСуммаБаллов;
                // *** Start programmer edit section *** (Идея.СуммаБаллов Get end)

                // *** End programmer edit section *** (Идея.СуммаБаллов Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.СуммаБаллов Set start)

                // *** End programmer edit section *** (Идея.СуммаБаллов Set start)
                this.fСуммаБаллов = value;
                // *** Start programmer edit section *** (Идея.СуммаБаллов Set end)

                // *** End programmer edit section *** (Идея.СуммаБаллов Set end)
            }
        }
        
        /// <summary>
        /// Идея.
        /// </summary>
        // *** Start programmer edit section *** (Идея.Автор CustomAttributes)

        // *** End programmer edit section *** (Идея.Автор CustomAttributes)
        [NotNull()]
        public virtual NewPlatform.OrmTestsObjects.Пользователь Автор
        {
            get
            {
                // *** Start programmer edit section *** (Идея.Автор Get start)

                // *** End programmer edit section *** (Идея.Автор Get start)
                NewPlatform.OrmTestsObjects.Пользователь result = this.fАвтор;
                // *** Start programmer edit section *** (Идея.Автор Get end)

                // *** End programmer edit section *** (Идея.Автор Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.Автор Set start)

                // *** End programmer edit section *** (Идея.Автор Set start)
                this.fАвтор = value;
                // *** Start programmer edit section *** (Идея.Автор Set end)

                // *** End programmer edit section *** (Идея.Автор Set end)
            }
        }
        
        /// <summary>
        /// Идея.
        /// </summary>
        // *** Start programmer edit section *** (Идея.Конкурс CustomAttributes)

        // *** End programmer edit section *** (Идея.Конкурс CustomAttributes)
        [NotNull()]
        public virtual NewPlatform.OrmTestsObjects.Конкурс Конкурс
        {
            get
            {
                // *** Start programmer edit section *** (Идея.Конкурс Get start)

                // *** End programmer edit section *** (Идея.Конкурс Get start)
                NewPlatform.OrmTestsObjects.Конкурс result = this.fКонкурс;
                // *** Start programmer edit section *** (Идея.Конкурс Get end)

                // *** End programmer edit section *** (Идея.Конкурс Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.Конкурс Set start)

                // *** End programmer edit section *** (Идея.Конкурс Set start)
                this.fКонкурс = value;
                // *** Start programmer edit section *** (Идея.Конкурс Set end)

                // *** End programmer edit section *** (Идея.Конкурс Set end)
            }
        }
        
        /// <summary>
        /// Идея.
        /// </summary>
        // *** Start programmer edit section *** (Идея.ЗначенияКритериев CustomAttributes)

        // *** End programmer edit section *** (Идея.ЗначенияКритериев CustomAttributes)
        public virtual NewPlatform.OrmTestsObjects.DetailArrayOfЗначениеКритерия ЗначенияКритериев
        {
            get
            {
                // *** Start programmer edit section *** (Идея.ЗначенияКритериев Get start)

                // *** End programmer edit section *** (Идея.ЗначенияКритериев Get start)
                if ((this.fЗначенияКритериев == null))
                {
                    this.fЗначенияКритериев = new NewPlatform.OrmTestsObjects.DetailArrayOfЗначениеКритерия(this);
                }
                NewPlatform.OrmTestsObjects.DetailArrayOfЗначениеКритерия result = this.fЗначенияКритериев;
                // *** Start programmer edit section *** (Идея.ЗначенияКритериев Get end)

                // *** End programmer edit section *** (Идея.ЗначенияКритериев Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.ЗначенияКритериев Set start)

                // *** End programmer edit section *** (Идея.ЗначенияКритериев Set start)
                this.fЗначенияКритериев = value;
                // *** Start programmer edit section *** (Идея.ЗначенияКритериев Set end)

                // *** End programmer edit section *** (Идея.ЗначенияКритериев Set end)
            }
        }
        
        /// <summary>
        /// Идея.
        /// </summary>
        // *** Start programmer edit section *** (Идея.ОценкиЭкспертов CustomAttributes)

        // *** End programmer edit section *** (Идея.ОценкиЭкспертов CustomAttributes)
        public virtual NewPlatform.OrmTestsObjects.DetailArrayOfОценкаЭксперта ОценкиЭкспертов
        {
            get
            {
                // *** Start programmer edit section *** (Идея.ОценкиЭкспертов Get start)

                // *** End programmer edit section *** (Идея.ОценкиЭкспертов Get start)
                if ((this.fОценкиЭкспертов == null))
                {
                    this.fОценкиЭкспертов = new NewPlatform.OrmTestsObjects.DetailArrayOfОценкаЭксперта(this);
                }
                NewPlatform.OrmTestsObjects.DetailArrayOfОценкаЭксперта result = this.fОценкиЭкспертов;
                // *** Start programmer edit section *** (Идея.ОценкиЭкспертов Get end)

                // *** End programmer edit section *** (Идея.ОценкиЭкспертов Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.ОценкиЭкспертов Set start)

                // *** End programmer edit section *** (Идея.ОценкиЭкспертов Set start)
                this.fОценкиЭкспертов = value;
                // *** Start programmer edit section *** (Идея.ОценкиЭкспертов Set end)

                // *** End programmer edit section *** (Идея.ОценкиЭкспертов Set end)
            }
        }
        
        /// <summary>
        /// Идея.
        /// </summary>
        // *** Start programmer edit section *** (Идея.Файлы CustomAttributes)

        // *** End programmer edit section *** (Идея.Файлы CustomAttributes)
        public virtual NewPlatform.OrmTestsObjects.DetailArrayOfФайлИдеи Файлы
        {
            get
            {
                // *** Start programmer edit section *** (Идея.Файлы Get start)

                // *** End programmer edit section *** (Идея.Файлы Get start)
                if ((this.fФайлы == null))
                {
                    this.fФайлы = new NewPlatform.OrmTestsObjects.DetailArrayOfФайлИдеи(this);
                }
                NewPlatform.OrmTestsObjects.DetailArrayOfФайлИдеи result = this.fФайлы;
                // *** Start programmer edit section *** (Идея.Файлы Get end)

                // *** End programmer edit section *** (Идея.Файлы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Идея.Файлы Set start)

                // *** End programmer edit section *** (Идея.Файлы Set start)
                this.fФайлы = value;
                // *** Start programmer edit section *** (Идея.Файлы Set end)

                // *** End programmer edit section *** (Идея.Файлы Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ИдеяE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ИдеяE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ИдеяE", typeof(NewPlatform.OrmTestsObjects.Идея));
                }
            }
        }
    }
}
