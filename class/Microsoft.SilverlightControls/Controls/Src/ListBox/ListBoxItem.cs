﻿// Copyright © Microsoft Corporation. 
// This source is subject to the Microsoft Source License for Silverlight Controls (March 2008 Release).
// Please see http://go.microsoft.com/fwlink/?LinkID=111693 for details.
// All other rights reserved. 

using System;
using System.Diagnostics; 
using System.Windows; 
using System.Windows.Controls;
using System.Windows.Input; 
using System.Windows.Media.Animation;

#if WPF 
using PropertyChangedCallback = System.Windows.FrameworkPropertyMetadata;
#endif
 
#if WPF 
namespace WPF
#else 
namespace System.Windows.Controls
#endif
{ 
    /// <summary>
    /// Represents a selectable item in a ListBox.
    /// </summary> 
    [TemplateVisualStateAttribute(Name = "Normal", GroupName = "CommonStates")]
    [TemplateVisualStateAttribute(Name = "Focused", GroupName = "FocusStates")]
    [TemplateVisualStateAttribute(Name = "MouseOver", GroupName = "CommonStates")]
    [TemplateVisualStateAttribute(Name = "Disabled", GroupName = "CommonStates")]
    [TemplateVisualStateAttribute(Name = "Unselected", GroupName = "SelectionStates")]
    [TemplateVisualStateAttribute(Name = "Selected", GroupName = "SelectionStates")]
    [TemplateVisualStateAttribute(Name = "SelectedUnfocused", GroupName = "SelectionStates")]
    [TemplateVisualStateAttribute(Name = "Unfocused", GroupName = "FocusStates")]
    public class ListBoxItem : ContentControl 
    { 
        /// <summary>
        /// Gets or sets a value that indicates whether a ListBoxItem is selected. 
        /// </summary>
        public bool IsSelected
        { 
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        } 
 
        /// <summary>
        /// Identifies the IsSelected dependency property. 
        /// </summary>
        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register(
            "IsSelected", typeof(bool), typeof(ListBoxItem), 
            new PropertyMetadata(new PropertyChangedCallback(OnIsSelectedChanged)));

        /// <summary> 
        /// Gets a value that indicates whether the mouse pointer is located over this element. 
        /// </summary>
        internal bool IsMouseOver { get; private set; } 

        /// <summary>
        /// Identifies the ItemsControl item represented by this object (null when this object IS the item) 
        /// </summary>
        internal object Item { get; set; }
 
        /// <summary> 
        /// Identifies the parent ListBox.
        /// </summary> 
        internal ListBox ParentListBox { get; set; }

        internal bool IsFocused { get; set; }

        /// <summary>
        /// Initializes a new instance of the ListBoxItem class. 
        /// </summary> 
        public ListBoxItem()
        { 
        DefaultStyleKey = typeof (ListBoxItem);
#if WPF
            KeyboardNavigation.SetDirectionalNavigation(this, KeyboardNavigationMode.Once);
            KeyboardNavigation.SetTabNavigation(this, KeyboardNavigationMode.Local); 
#else
            // DirectionalNavigation not supported by Silverlight
            TabNavigation = KeyboardNavigationMode.Local; 
#endif 
            IsTabStop = true;
        }
 
        /// <summary> 
        /// Invoked whenever application code or internal processes call
        /// ApplyTemplate. 
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

        // anything else here?
        } 

        /// <summary>
        /// Called when the user presses the left mouse button over the ListBoxItem. 
        /// </summary>
        /// <param name="e">The event data.</param>
        protected virtual void OnMouseLeftButtonDown(MouseButtonEventArgs e) 
        { 
            if (!e.Handled)
            { 
                e.Handled = true;
                if (Focus())
                { 
                    if (null != ParentListBox)
                    {
                        ParentListBox.NotifyListItemClicked(this); 
                    } 
                }
            } 
        }

        /// <summary> 
        /// Called when the mouse pointer enters the bounds of this element.
        /// </summary>
        /// <param name="e">The event data.</param> 
        protected virtual void OnMouseEnter(MouseEventArgs e) 
        {
            IsMouseOver = true; 
            ChangeVisualState();
        }
 
        /// <summary>
        /// Called when the mouse pointer leaves the bounds of this element.
        /// </summary> 
        /// <param name="e">The event data.</param> 
        protected virtual void OnMouseLeave(MouseEventArgs e)
        { 
            IsMouseOver = false;
            ChangeVisualState();
        } 

        /// <summary>
        /// Called when the control got focus. 
        /// </summary> 
        /// <param name="e">The event data.</param>
        protected virtual void OnGotFocus(RoutedEventArgs e) 
        {
            base.OnGotFocus(e);
            IsFocused = true;
            ChangeVisualState ();

            if (null != ParentListBox) {
                ParentListBox.NotifyListItemGotFocus(this);
            } 
        }

        /// <summary> 
        /// Called when the control lost focus.
        /// </summary>
        /// <param name="e">The event data.</param> 
        protected virtual void OnLostFocus(RoutedEventArgs e) 
        {
            base.OnLostFocus (e);
            IsFocused = false;
            ChangeVisualState ();
            if (null != ParentListBox) {
                ParentListBox.NotifyListItemLostFocus(this); 
            }
        }
 
        /// <summary>
        /// Implements the IsSelectedProperty PropertyChangedCallback.
        /// </summary> 
        /// <param name="d">The DependencyObject for which the property changed.</param>
        /// <param name="e">Provides data for DependencyPropertyChangedEventArgs.</param>
        private static void OnIsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) 
        { 
            ListBoxItem listBoxItem = d as ListBoxItem;
            Debug.Assert(null != listBoxItem); 
            Debug.Assert(typeof(bool).IsInstanceOfType(e.OldValue));
            Debug.Assert(typeof(bool).IsInstanceOfType(e.NewValue));
            listBoxItem.ChangeVisualState(); 
        }

        /// <summary> 
        /// Changes the visual state by playing the appropriate Storyboard 
        /// </summary>
        internal void ChangeVisualState()
        {
            if (!IsEnabled) {
                VisualStateManager.GoToState (this, "Disabled", true);
            }
            else if (IsSelected) {
                VisualStateManager.GoToState (this, "Selected", true);
            }
            else if (IsMouseOver) {
                VisualStateManager.GoToState (this, "MouseOver", true);
            }
            else {
                VisualStateManager.GoToState (this, "Normal", true);
            }
        }
    }
}
