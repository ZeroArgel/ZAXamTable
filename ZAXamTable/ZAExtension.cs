namespace ZAXamTable
{
    using System;
    using System.Collections.Generic;
    using Xamarin.Forms;
    using static ZAEnums;
    /// <summary>
    /// ZAExtension to create a dynamic tables more faster.
    /// </summary>
    public static class ZAExtension
    {
        #region ToHeader
        /// <summary>
        /// This functions create a grid Xamarin to the header part.
        /// </summary>
        /// <param name="_grid">{Type=Grid}</param>
        /// <param name="_headers">{Type=IEnumerable<ZAHeaders>}</param>
        public static void ToHeader(this Grid _grid, IEnumerable<ZAHeaders> _headers)
        {
            // Create and asign id to Grid Header.
            var gridHeader = new Grid();
            
            // Add childrens into Grid.
            foreach (var _header in _headers) 
                gridHeader.Children.Add(_header.ToLabel(), _header.Position.Column, _header.Position.Row);

            // Clean grid header
            _grid.Children.Clear();

            // Add headers into grid.
            _grid.Children.Add(gridHeader); // Add Hearder
        }
        #endregion
        #region ToSource
        /// <summary>
        /// This functions create a grid Xamarin to the source part.
        /// </summary>
        /// <param name="_grid">{Type=Grid}</param>
        /// <param name="_sources">{Type=IEnumerable<ZASources>}</param>
        public static void ToSource(this Grid _grid, IEnumerable<ZASources> _sources)
        {
            // Create and asign id to Grid Source.
            var gridSource = new Grid();

            // Add childrens into Grid.
            foreach (var _source in _sources)
            {
                switch (_source.TypeElement)
                {
                    case ZATypeElement.Label: gridSource.Children.Add(_source.ToLabel(), _source.Position.Column, _source.Position.Row); break;
                    case ZATypeElement.Entry: gridSource.Children.Add(_source.ToEntry(), _source.Position.Column, _source.Position.Row); break;
                    default: throw new Exception("Review documentation and try again");
                }
            }

            // Clean grid source
            _grid.Children.Clear();

            // Add sources into grid.
            _grid.Children.Add(gridSource); // Add Source
        }
        #endregion
        #region ToEntry
        /// <summary>
        /// This functions create a new entry xamarin element.
        /// </summary>
        /// <param name="_sources">{Type=ZASources}</param>
        /// <returns></returns>
        private static Entry ToEntry(this ZASources _sources)
        {
            var entry = new Entry
            {
                Text = _sources.Text,
                FontSize = _sources.CustomFontSize > 0 ? _sources.CustomFontSize : (double)_sources.FontSize,
                Placeholder = _sources.Placeholder,
                WidthRequest = _sources.WidthRequest,
                HorizontalOptions = _sources.HorizontalOptions,
                VerticalOptions = _sources.VerticalOptions,
                Keyboard = _sources.Keyboard
            };
            if (_sources.Behavior != null) entry.Behaviors.Add(_sources.Behavior);
            return entry;
        }
        #endregion
        #region ToLabel
        /// <summary>
        /// This functions create a new label xamarin element.
        /// </summary>
        /// <param name="_headers">{Type=ZAHeaders}</param>
        /// <returns></returns>
        private static Label ToLabel(this ZAHeaders _headers)
        {
            return new Label()
            {
                Text = _headers.Text,
                TextColor = _headers.TextColor,
                BackgroundColor = _headers.BackgroundColor,
                FontSize = _headers.CustomFontSize > 0 ? _headers.CustomFontSize : (double)_headers.FontSize,
                HorizontalOptions = _headers.HorizontalOptions,
                VerticalOptions = _headers.VerticalOptions,
                HorizontalTextAlignment = _headers.HorizontalTextAlignment,
                VerticalTextAlignment = _headers.VerticalTextAlignment
            };
        }
        /// <summary>
        /// This functions create a new label xamarin element.
        /// </summary>
        /// <param name="_sources">{Type=ZASources}</param>
        /// <returns></returns>
        private static Label ToLabel(this ZASources _sources)
        {
            return new Label()
            {
                Text = _sources.Text,
                TextColor = _sources.TextColor,
                BackgroundColor = _sources.BackgroundColor,
                FontSize = _sources.CustomFontSize > 0 ? _sources.CustomFontSize : (double)_sources.FontSize,
                HorizontalOptions = _sources.HorizontalOptions,
                VerticalOptions = _sources.VerticalOptions,
                HorizontalTextAlignment = _sources.HorizontalTextAlignment,
                VerticalTextAlignment = _sources.VerticalTextAlignment
            };
        }
        #endregion
    }
}