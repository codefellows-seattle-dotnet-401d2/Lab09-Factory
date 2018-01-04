using System;
using System.Collections.Generic;
using System.Text;

namespace TheFactory.Abstracts
{
    public enum ObjectClass 
    {
        Neutralized, Explained, Safe,
        Euclid, Keter, Thaumiel, Custom
    }

    [Serializable]
    public class SCPDocument : Document
    {
        public string SCPNumber
        {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }
        public ObjectClass ObjectClass { get; set; }
        public string SpecialContainmentProceedures { get; set; }
        public string Description { get; set; }

        public SCPDocument(string title,ObjectClass objectclass,string scproceedures,string description)
        {
            Title = title;
            ObjectClass = objectclass;
            SpecialContainmentProceedures = scproceedures;
            Description = description;
        }
    }
}
