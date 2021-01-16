﻿namespace JMXFileEditor.ViewModels
{
    /// <summary>
    /// Viewmodel to represent any type of property the JMX file has
    /// </summary>
    public class JMXProperty : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// Name to identify the property
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Check if the value can be edited
        /// </summary>
        public bool IsEditable { get; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        protected JMXProperty(string Name, bool IsEditable)
        {
            this.Name = Name;
            this.IsEditable = IsEditable;
        }
        #endregion
    }
}
