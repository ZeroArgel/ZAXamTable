namespace ZAXamTable
{
    using Xamarin.Forms;
    using static ZAEnums;
    /// <summary>
    /// This class is used for create standard headers in table.
    /// </summary>
    public class ZAHeaders
    {
        /// <summary>
        /// Constructor empty, for classic instance.
        /// </summary>
        public ZAHeaders() { }
        /// <summary>
        /// Constructor with properties, for more easier and basic data to create headears.
        /// </summary>
        /// <param name="_text">{Type=string}</param>
        /// <param name="_position">{Type=ZAPosition}</param>
        public ZAHeaders(string _text, ZAPosition _position)
        {
            Text = _text;
            Position = _position;
        }
        /// <summary>
        /// This property save the position of element current. for default is a null.
        /// Position {Type=ZAPosition}, Default=null
        /// </summary>
        public ZAPosition Position { get; set; } = null;
        /// <summary>
        /// This property save the text of element current. for default is a "".
        /// Text {Type=string}, Default=""
        /// </summary>
        public string Text { get; set; } = "";
        /// <summary>
        /// This property save the size of font to element current. for default is a ZAFontSize.Large.
        /// If you want customer size, then change property CustomFontSize for other positive number.
        /// FontSize {Type=ZAFontSize}, Default=ZAFontSize.Large
        /// </summary>
        public ZAFontSize FontSize { get; set; } = ZAFontSize.Large;
        /// <summary>
        /// This property save the size of font. for default is 0.
        /// If you want customer size, then change property CustomFontSize for other positive number.
        /// CustomFontSize {Type=double}, Default=0
        /// </summary>
        public double CustomFontSize { get; set; } = 0;
        /// <summary>
        /// This property save color of text in of element current. for default is a Color.Black.
        /// TextColor {Type=Color}, Default=Color.Black
        /// </summary>
        public Color TextColor { get; set; } = Color.Black;
        /// <summary>
        /// This property save color of background in of element current. for default is a Color.Transparent.
        /// BackgroundColor {Type=Color}, Default=Color.Transparent
        /// </summary>
        public Color BackgroundColor { get; set; } = Color.Transparent;
        /// <summary>
        /// This property save horizontal option in of element current. for default is a LayoutOptions.StartAndExpand.
        /// HorizontalOptions {Type=LayoutOptions}, Default=LayoutOptions.StartAndExpand
        /// </summary>
        public LayoutOptions HorizontalOptions { get; set; } = LayoutOptions.StartAndExpand;
        /// <summary>
        /// This property save vertical option in of element current. for default is a LayoutOptions.StartAndExpand.
        /// VerticalOptions {Type=LayoutOptions}, Default=LayoutOptions.StartAndExpand
        /// </summary>
        public LayoutOptions VerticalOptions { get; set; } = LayoutOptions.StartAndExpand;
        /// <summary>
        /// This property save horizontal text align in of element current. for default is a TextAlignment.Center.
        /// HorizontalTextAlignment {Type=TextAlignment}, Default=TextAlignment.Center
        /// </summary>
        public TextAlignment HorizontalTextAlignment { get; set; } = TextAlignment.Center;
        /// <summary>
        /// This property save vertical text align in of element current. for default is a TextAlignment.Center.
        /// VerticalTextAlignment {Type=TextAlignment}, Default=TextAlignment.Center
        /// </summary>
        public TextAlignment VerticalTextAlignment { get; set; } = TextAlignment.Center;
    }
}