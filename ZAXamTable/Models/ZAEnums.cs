namespace ZAXamTable
{
    /// <summary>
    /// Enums to cofig ZAXamTable with complicate lifes.
    /// </summary>
    public static class ZAEnums
    {
        #region ZAFontSize
        /// <summary>
        /// Enum with all format to FontSizes of label text or input text.
        /// </summary>
        public enum ZAFontSize
        {
            Title = 50,
            Body = 30,
            Large = 25,
            Medium = 20,
            Small = 15
        }
        #endregion
        #region ZATypeElement
        /// <summary>
        /// Types to create into fields of table.
        /// </summary>
        public enum ZATypeElement
        {
            Entry,
            Label
        }
        #endregion
    }
}