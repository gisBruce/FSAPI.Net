// <auto-generated>
//   This code was generated by Enunciate.
//   http://enunciate.codehaus.org/
// </auto-generated>
using FSAPI.Model;
using System;
using System.Runtime.Serialization;

namespace FSAPI.Identity.V1.Schema
{

    /// <remarks>
    ///  
    /// </remarks>
    /// <summary>
    ///  
    /// </summary>
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://api.familysearch.org/identity/v1", TypeName = "identity")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.familysearch.org/identity/v1", ElementName = "identity")]
    public partial class Identity : FamilySearchElement
    {

        private Session _session;
        /// <summary>
        ///  The session associated with the identity.
        /// </summary>
        
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "session", Namespace = "http://api.familysearch.org/identity/v1")]
        public Session Session
        {
            get
            {
                return this._session;
            }
            set
            {
                this._session = value;
            }
        }
    }
}
namespace FSAPI.Identity.V1.Schema
{

    /// <remarks>
    ///  A identity session.
    /// </remarks>
    /// <summary>
    ///  A identity session.
    /// </summary>
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://api.familysearch.org/identity/v1", TypeName = "session")]
    public partial class Session
    {

        private string _id;
        /// <summary>
        ///  The id of the session.
        /// </summary>
        
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "id")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}