﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.SalesShop
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Товар.
    /// </summary>
    //  *** Start programmer edit section *** (Товар CustomAttributes)

    //  *** End programmer edit section *** (Товар CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТоварE", new string[] {
            "Название as \'Название\'",
            "Описание as \'Описание\'"})]
    [View("ТоварL", new string[] {
            "Название as \'Название\'",
            "Описание as \'Описание\'"})]
    public class Товар : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        private string fОписание;
        
        //  *** Start programmer edit section *** (Товар CustomMembers)

        //  *** End programmer edit section *** (Товар CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        //  *** Start programmer edit section *** (Товар.Название CustomAttributes)

        //  *** End programmer edit section *** (Товар.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                //  *** Start programmer edit section *** (Товар.Название Get start)

                //  *** End programmer edit section *** (Товар.Название Get start)
                string result = this.fНазвание;
                //  *** Start programmer edit section *** (Товар.Название Get end)

                //  *** End programmer edit section *** (Товар.Название Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Товар.Название Set start)

                //  *** End programmer edit section *** (Товар.Название Set start)
                this.fНазвание = value;
                //  *** Start programmer edit section *** (Товар.Название Set end)

                //  *** End programmer edit section *** (Товар.Название Set end)
            }
        }
        
        /// <summary>
        /// Описание.
        /// </summary>
        //  *** Start programmer edit section *** (Товар.Описание CustomAttributes)

        //  *** End programmer edit section *** (Товар.Описание CustomAttributes)
        [StrLen(255)]
        public virtual string Описание
        {
            get
            {
                //  *** Start programmer edit section *** (Товар.Описание Get start)

                //  *** End programmer edit section *** (Товар.Описание Get start)
                string result = this.fОписание;
                //  *** Start programmer edit section *** (Товар.Описание Get end)

                //  *** End programmer edit section *** (Товар.Описание Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Товар.Описание Set start)

                //  *** End programmer edit section *** (Товар.Описание Set start)
                this.fОписание = value;
                //  *** Start programmer edit section *** (Товар.Описание Set end)

                //  *** End programmer edit section *** (Товар.Описание Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТоварE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварE", typeof(IIS.SalesShop.Товар));
                }
            }
            
            /// <summary>
            /// "ТоварL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварL", typeof(IIS.SalesShop.Товар));
                }
            }
        }
    }
}
