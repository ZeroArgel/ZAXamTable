namespace ZAXamTable
{
    using Xamarin.Forms;
    using static ZAEnums;
    /// <summary>
    /// This class is used for create standard sources or body in table.
    /// </summary>
    public class ZASources
    {
        /// <summary>
        /// Constructor empty, for classic instance.
        /// </summary>
        public ZASources() { }
        /// <summary>
        /// Constructor with properties, for more easier and basic data to create sources.
        /// </summary>
        /// <param name="_text">{Type=string}</param>
        /// <param name="_position">{Type=ZAPosition}</param>
        public ZASources(string _text, ZAPosition _position)
        {
            Text = _text;
            Position = _position;
        }
        /// <summary>
        /// This property save the type the element. for default is a Xamarin Label
        /// TypeElement {Type=ZATypeElement}, Default=ZATypeElement.Label
        /// </summary>
        public ZATypeElement TypeElement { get; set; } = ZATypeElement.Label;
        /// <summary>
        /// This property save the size of font. for default is a Medium size. 
        /// If you want customer size, then change property CustomFontSize for other positive number.
        /// FontSize {Type=ZAFontSize}, Default=ZAFontSize.Medium
        /// </summary>
        public ZAFontSize FontSize { get; set; } = ZAFontSize.Medium;
        /// <summary>
        /// This property save the size of font. for default is 0.
        /// If you want customer size, then change property CustomFontSize for other positive number.
        /// CustomFontSize {Type=double}, Default=0
        /// </summary>
        public double CustomFontSize { get; set; } = 0;
        /// <summary>
        /// TextColor {Type=Color}, Default=Color.Black
        /// </summary>
        public Color TextColor { get; set; } = Color.Black;
        /// <summary>
        /// This property save color of background in of element current. for default is a Color.Transparent.
        /// BackgroundColor {Type=Color}, Default=Color.Transparent
        /// </summary>
        public Color BackgroundColor { get; set; } = Color.Transparent;
        /// <summary>
        /// This property save the text of element current. for default is a "".
        /// Text {Type=string}, Default=""
        /// </summary>
        public string Text { get; set; } = "";
        /// <summary>
        /// This property save the placeholder of element current. for default is a "".
        /// Placeholder {Type=string}, Default=""
        /// </summary>
        public string Placeholder { get; set; } = "";
        /// <summary>
        /// This property save the width of element current. for default is a 250.
        /// WidthRequest {Type=int}, Default=250
        /// </summary>
        public int WidthRequest { get; set; } = 250;
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
        /// TextAlignment {Type=TextAlignment}, Default=TextAlignment.Start
        /// </summary>
        public TextAlignment HorizontalTextAlignment { get; set; } = TextAlignment.Start;
        /// <summary>
        /// This property save vertical text align in of element current. for default is a TextAlignment.Center.
        /// VerticalTextAlignment {Type=TextAlignment}, Default=TextAlignment.Start
        /// </summary>
        public TextAlignment VerticalTextAlignment { get; set; } = TextAlignment.Start;
        /// <summary>
        /// This property save keyboard type in element current. for default is a null
        /// Keyboard {Type=Keyboard}, Default=null
        /// </summary>
        public Keyboard Keyboard { get; set; } = null;
        /// <summary>
        /// This property save behavior or function in element current. for default is a null
        /// Behavior {Type=Behavior}, Default=null
        /// </summary>
        public Behavior Behavior { get; set; } = null;
        /// <summary>
        /// This property save the position of element current. for default is a null.
        /// Position {Type=ZAPosition}, Default=null
        /// </summary>
        public ZAPosition Position { get; set; } = null;
    }
}