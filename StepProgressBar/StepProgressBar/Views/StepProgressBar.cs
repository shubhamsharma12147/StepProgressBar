using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace StepProgressBar.Views
{
    public class StepProgressBar : ContentView
    {

        #region Steps (Bindable int)
        public static readonly BindableProperty StepsProperty =
            BindableProperty.Create(propertyName: nameof(Steps),
                                    returnType: typeof(int),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: 5);
        /// <summary>
        /// Default value - 5
        /// </summary>
        public int Steps
        {
            get { return (int)GetValue(StepsProperty); }
            set { SetValue(StepsProperty, value); }
        }
        #endregion Steps (Bindable int)


        #region CircleWidth (Bindable double)
        public static readonly BindableProperty CircleWidthProperty =
            BindableProperty.Create(propertyName: nameof(CircleWidth),
                                    returnType: typeof(double),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: 10D);
        /// <summary>
        /// Default value - 10
        /// </summary>
        public double CircleWidth
        {
            get { return (double)GetValue(CircleWidthProperty); }
            set { SetValue(CircleWidthProperty, value); }
        }
        #endregion CircleWidth (Bindable double)


        #region CurrentStep (Bindable int)
        public static readonly BindableProperty CurrentStepProperty =
            BindableProperty.Create(propertyName: nameof(CurrentStep),
                                    returnType: typeof(int),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: 0);
        /// <summary>
        /// Default value - 0
        /// </summary>
        public int CurrentStep
        {
            get { return (int)GetValue(CurrentStepProperty); }
            set { SetValue(CurrentStepProperty, value); }
        }
        #endregion CurrentStep (Bindable int)

        #region StepsColorProperty (Bindable Color)
        public static readonly BindableProperty StepsColorProperty =
            BindableProperty.Create(propertyName: nameof(StepsColor),
                                    returnType: typeof(Color),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: Color.Gray);
        /// <summary>
        /// Default value - Color.Gray
        /// </summary>
        public Color StepsColor
        {
            get { return (Color)GetValue(StepsColorProperty); }
            set { SetValue(StepsColorProperty, value); }
        }
        #endregion CircleColor (Bindable Color)


        #region SelectedStapsColor (Bindable Color)
        public static readonly BindableProperty SelectedStapsColorProperty =
            BindableProperty.Create(propertyName: nameof(SelectedStapsColor),
                                    returnType: typeof(Color),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: Color.Black);
        /// <summary>
        /// Default value - Color.Black
        /// </summary>
        public Color SelectedStapsColor
        {
            get { return (Color)GetValue(SelectedStapsColorProperty); }
            set { SetValue(SelectedStapsColorProperty, value); }
        }
        #endregion SelectedStapsColor (Bindable Color)


        #region StripColor (Bindable Color)
        public static readonly BindableProperty StripColorProperty =
            BindableProperty.Create(propertyName: nameof(StripColor),
                                    returnType: typeof(Color),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: Color.Gray);
        /// <summary>
        /// Default value - Color.Gray
        /// </summary>
        public Color StripColor
        {
            get { return (Color)GetValue(StripColorProperty); }
            set { SetValue(StripColorProperty, value); }
        }
        #endregion StripColor (Bindable Color)

        #region TagsSource (Bindable IList<String>)
        public static readonly BindableProperty TagsSourceProperty =
            BindableProperty.Create(propertyName: nameof(TagsSource),
                                    returnType: typeof(IList<String>),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: null,
                                    validateValue:validateValue);

        private static bool validateValue(BindableObject bindable, object value)
        {
            return ((IList<string>)value).Count == ((StepProgressBar)bindable).Steps;
        }

        /// <summary>
        /// Tags count must be equal to Steps count
        /// </summary>
        public IList<String> TagsSource
        {
            get { return (IList<String>)GetValue(TagsSourceProperty); }
            set { SetValue(TagsSourceProperty, value); }
        }
        #endregion TagsSource (Bindable IList<String>)




        #region StripWidth (Bindable double)
        public static readonly BindableProperty StripWidthProperty =
            BindableProperty.Create(propertyName: nameof(StripWidth),
                                    returnType: typeof(double),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: 2D);
        /// <summary>
        /// Default value - 2
        /// </summary>
        public double StripWidth
        {
            get { return (double)GetValue(StripWidthProperty); }
            set { SetValue(StripWidthProperty, value); }
        }
        #endregion StripWidth (Bindable double)


        #region LabelStyle (Bindable Style)
        public static readonly BindableProperty LabelStyleProperty =
            BindableProperty.Create(propertyName: nameof(LabelStyle),
                                    returnType: typeof(Style),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: null);
        public Style LabelStyle
        {
            get { return (Style)GetValue(LabelStyleProperty); }
            set { SetValue(LabelStyleProperty, value); }
        }
        #endregion LabelStyle (Bindable Style)


        #region ImageStyle (Bindable Style)
        public static readonly BindableProperty ImageStyleProperty =
            BindableProperty.Create(propertyName: nameof(ImageStyle),
                                    returnType: typeof(Style),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: null);
        public Style ImageStyle
        {
            get { return (Style)GetValue(ImageStyleProperty); }
            set { SetValue(ImageStyleProperty, value); }
        }
        #endregion ImageStyle (Bindable Style)

        #region SelectedImageSourceCollection (Bindable IList<ImageSource>)
        public static readonly BindableProperty SelectedImageSourceCollectionProperty =
            BindableProperty.Create(propertyName: nameof(SelectedImageSourceCollection),
                                    returnType: typeof(IList<ImageSource>),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: null,
                                    validateValue: SelectedImageSourceValidation);
        public IList<ImageSource> SelectedImageSourceCollection
        {
            get { return (IList<ImageSource>)GetValue(SelectedImageSourceCollectionProperty); }
            set { SetValue(SelectedImageSourceCollectionProperty, value); }
        }
        private static bool SelectedImageSourceValidation(BindableObject bindable, object value)
        {
            if (value == null)
                return true;
            return ((IList<ImageSource>)value).Count == ((StepProgressBar)bindable).Steps;
        }
        #endregion SelectedImageSourceCollection (Bindable ImageSource)




        #region ImageSourceCollection (Bindable IList<ImageSource>)
        public static readonly BindableProperty ImageSourceCollectionProperty =
            BindableProperty.Create(propertyName: nameof(ImageSourceCollection),
                                    returnType: typeof(IList<ImageSource>),
                                    declaringType: typeof(StepProgressBar),
                                    defaultValue: null,validateValue:ImageSourceValidation);

        private static bool ImageSourceValidation(BindableObject bindable, object value)
        {
            if (value == null)
                return true;
            return ((IList<ImageSource>)value).Count == ((StepProgressBar)bindable).Steps;
        }

        public IList<ImageSource> ImageSourceCollection
        {
            get { return (IList<ImageSource>)GetValue(ImageSourceCollectionProperty); }
            set { SetValue(ImageSourceCollectionProperty, value); }
        }
        #endregion ImageSourceCollection (Bindable IList<ImageSource>)
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == StepsProperty.PropertyName
                || propertyName == CurrentStepProperty.PropertyName 
                || propertyName == TagsSourceProperty.PropertyName
                || propertyName==ImageSourceCollectionProperty.PropertyName
                || propertyName==SelectedImageSourceCollectionProperty.PropertyName)
            {
                GenrateBarStepper();
            }
        }

        private void GenrateBarStepper()
        {
            StackLayout Outerstack = new StackLayout
            {

            };
            StackLayout stack = new StackLayout
            {
                Margin = new Thickness(15, 0),
                Spacing = 0,
                Orientation = StackOrientation.Horizontal
            };
            for (int i = 0; i < Steps; i++)
            {
                var frame = new Frame
                {
                    HorizontalOptions = LayoutOptions.Center,
                    CornerRadius = 50,
                    HasShadow=false
                };
                if (ImageSourceCollection != null && ImageSourceCollection?.Count != 0)
                {
                    var img = new Image
                    {
                        Source = i < CurrentStep?SelectedImageSourceCollection[i]:ImageSourceCollection[i],
                    };
                    img.SetBinding(Image.StyleProperty, new Binding(ImageStyleProperty.PropertyName, source: this));
                    frame.Padding = new Thickness(0);
                    frame.BackgroundColor = Color.Transparent;
                    frame.Content = img;
                }
                else
                {
                    frame.SetBinding(Frame.PaddingProperty, new Binding(CircleWidthProperty.PropertyName, source: this));
                    if (i < CurrentStep)
                        frame.SetBinding(Frame.BackgroundColorProperty, new Binding(SelectedStapsColorProperty.PropertyName, source: this));
                    else
                        frame.SetBinding(Frame.BackgroundColorProperty, new Binding(StepsColorProperty.PropertyName, source: this));
                }
                    if (i == 0)
                {
                    stack.Children.Add(frame);
                    continue;
                }
                var boxview = new BoxView
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.Center,
                };
                boxview.SetBinding(BoxView.HeightRequestProperty, new Binding(StripWidthProperty.PropertyName, source: this));
                if (i < CurrentStep)
                    boxview.SetBinding(BoxView.ColorProperty, new Binding(SelectedStapsColorProperty.PropertyName, source: this));
                else
                    boxview.SetBinding(BoxView.ColorProperty, new Binding(StripColorProperty.PropertyName, source: this));
                stack.Children.Add(boxview);
                stack.Children.Add(frame);
            }
            Outerstack.Children.Add(stack);
            if (TagsSource != null || TagsSource?.Count >= Steps)
            {
                StackLayout tagstack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal
                };
                for (int i = 0; i < Steps; i++)
                {
                    var label = new Label
                    {
                        Text = TagsSource[i],
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    };
                    if (i == 0)
                        label.HorizontalOptions = LayoutOptions.StartAndExpand;
                    if (i == Steps - 1)
                        label.HorizontalOptions = LayoutOptions.EndAndExpand;
                    label.SetBinding(Label.StyleProperty, new Binding(LabelStyleProperty.PropertyName, source: null));
                    tagstack.Children.Add(label);
                }
                Outerstack.Children.Add(tagstack);
            }
            Content = Outerstack;
        }
    }
}
