﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.IMGUI.Controls.SearchField
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
  /// <summary>
  ///   <para>The SearchField control creates a text field for a user to input text that can be used for searching.</para>
  /// </summary>
  public class SearchField
  {
    private bool m_AutoSetFocusOnFindCommand = true;
    private int m_ControlID;
    private bool m_WantsFocus;
    private const float kMinWidth = 36f;
    private const float kMaxWidth = 1E+07f;
    private const float kMinToolbarWidth = 29f;
    private const float kMaxToolbarWidth = 200f;

    public SearchField()
    {
      this.m_ControlID = GUIUtility.GetPermanentControlID();
    }

    public event SearchField.SearchFieldCallback downOrUpArrowKeyPressed;

    /// <summary>
    ///   <para>This is the controlID used for the text field to obtain keyboard focus.</para>
    /// </summary>
    public int searchFieldControlID
    {
      get
      {
        return this.m_ControlID;
      }
      set
      {
        this.m_ControlID = value;
      }
    }

    /// <summary>
    ///   <para>Changes the keyboard focus to the search field when the user presses ‘Ctrl/Cmd + F’ when set to true. It is true by default.</para>
    /// </summary>
    public bool autoSetFocusOnFindCommand
    {
      get
      {
        return this.m_AutoSetFocusOnFindCommand;
      }
      set
      {
        this.m_AutoSetFocusOnFindCommand = value;
      }
    }

    /// <summary>
    ///   <para>This function changes keyboard focus to the search field so a user can start typing.</para>
    /// </summary>
    public void SetFocus()
    {
      this.m_WantsFocus = true;
    }

    /// <summary>
    ///   <para>This function returns true if the search field has keyboard focus.</para>
    /// </summary>
    public bool HasFocus()
    {
      return GUIUtility.keyboardControl == this.m_ControlID;
    }

    /// <summary>
    ///   <para>This function displays a search text field with the given Rect and UI style parameters.</para>
    /// </summary>
    /// <param name="rect">Rectangle to use for the search field.</param>
    /// <param name="text">Text string to display in the search field.</param>
    /// <param name="style">The text field style.</param>
    /// <param name="cancelButtonStyle">The cancel button style used when there is text in the search field.</param>
    /// <param name="emptyCancelButtonStyle">The cancel button style used when there is no text in the search field.</param>
    /// <returns>
    ///   <para>The text entered in the SearchField. The original input string is returned instead if the search field text was not changed.</para>
    /// </returns>
    public string OnGUI(Rect rect, string text, GUIStyle style, GUIStyle cancelButtonStyle, GUIStyle emptyCancelButtonStyle)
    {
      this.CommandEventHandling();
      this.FocusAndKeyHandling();
      float fixedWidth = cancelButtonStyle.fixedWidth;
      Rect position1 = rect;
      position1.width -= fixedWidth;
      text = EditorGUI.TextFieldInternal(this.m_ControlID, position1, text, style);
      Rect position2 = rect;
      position2.x += rect.width - fixedWidth;
      position2.width = fixedWidth;
      if (GUI.Button(position2, GUIContent.none, !(text != "") ? emptyCancelButtonStyle : cancelButtonStyle) && text != "")
      {
        text = "";
        GUIUtility.keyboardControl = 0;
      }
      return text;
    }

    /// <summary>
    ///   <para>This function displays the search field with the default UI style in the given Rect.</para>
    /// </summary>
    /// <param name="rect">Rectangle to use for the search field.</param>
    /// <param name="text">Text string to display in the search field.</param>
    /// <returns>
    ///   <para>The text entered in the search field. The original input string is returned instead if the search field text was not changed.</para>
    /// </returns>
    public string OnGUI(Rect rect, string text)
    {
      return this.OnGUI(rect, text, EditorStyles.searchField, EditorStyles.searchFieldCancelButton, EditorStyles.searchFieldCancelButtonEmpty);
    }

    /// <summary>
    ///   <para>This function displays the search field with the default UI style and uses the GUILayout class to automatically calculate the position and size of the Rect it is rendered to. Pass an optional list to specify extra layout properties.</para>
    /// </summary>
    /// <param name="text">Text string to display in the search field.</param>
    /// <param name="options">An optional list of layout options that specify extra layout properties. &lt;br&gt;
    /// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight,
    /// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
    /// <returns>
    ///   <para>The text entered in the search field. The original input string is returned instead if the search field text was not changed.</para>
    /// </returns>
    public string OnGUI(string text, params GUILayoutOption[] options)
    {
      return this.OnGUI(GUILayoutUtility.GetRect(36f, 1E+07f, 16f, 16f, EditorStyles.searchField, options), text);
    }

    /// <summary>
    ///   <para>This function displays the search field with a toolbar style in the given Rect.</para>
    /// </summary>
    /// <param name="rect">Rectangle to use for the search field.</param>
    /// <param name="text">Text string to display in the search field.</param>
    /// <returns>
    ///   <para>The text entered in the search field. The original input string is returned instead if the search field text was not changed.</para>
    /// </returns>
    public string OnToolbarGUI(Rect rect, string text)
    {
      return this.OnGUI(rect, text, EditorStyles.toolbarSearchField, EditorStyles.toolbarSearchFieldCancelButton, EditorStyles.toolbarSearchFieldCancelButtonEmpty);
    }

    /// <summary>
    ///   <para>This function displays the search field with the toolbar UI style and uses the GUILayout class to automatically calculate the position and size of the Rect it is rendered to. Pass an optional list to specify extra layout properties.</para>
    /// </summary>
    /// <param name="text">Text string to display in the search field.</param>
    /// <param name="options">An optional list of layout options that specify extra layout properties. &lt;br&gt;
    /// See Also: GUILayout.Width, GUILayout.Height, GUILayout.MinWidth, GUILayout.MaxWidth, GUILayout.MinHeight,
    /// GUILayout.MaxHeight, GUILayout.ExpandWidth, GUILayout.ExpandHeight.</param>
    /// <returns>
    ///   <para>The text entered in the search field. The original input string is returned instead if the search field text was not changed.</para>
    /// </returns>
    public string OnToolbarGUI(string text, params GUILayoutOption[] options)
    {
      return this.OnToolbarGUI(GUILayoutUtility.GetRect(29f, 200f, 16f, 16f, EditorStyles.toolbarSearchField, options), text);
    }

    private void FocusAndKeyHandling()
    {
      Event current = Event.current;
      if (this.m_WantsFocus && current.type == EventType.Repaint)
      {
        GUIUtility.keyboardControl = this.m_ControlID;
        EditorGUIUtility.editingTextField = true;
        this.m_WantsFocus = false;
      }
      // ISSUE: reference to a compiler-generated field
      if (current.type != EventType.KeyDown || current.keyCode != KeyCode.DownArrow && current.keyCode != KeyCode.UpArrow || (GUIUtility.keyboardControl != this.m_ControlID || GUIUtility.hotControl != 0 || this.downOrUpArrowKeyPressed == null))
        return;
      // ISSUE: reference to a compiler-generated field
      this.downOrUpArrowKeyPressed();
      current.Use();
    }

    private void CommandEventHandling()
    {
      Event current = Event.current;
      if (current.type != EventType.ExecuteCommand && current.type != EventType.ValidateCommand || (!this.m_AutoSetFocusOnFindCommand || !(current.commandName == "Find")))
        return;
      if (current.type == EventType.ExecuteCommand)
        this.SetFocus();
      current.Use();
    }

    /// <summary>
    ///   <para>This is a generic callback delegate for SearchField events and does not take any parameters.</para>
    /// </summary>
    public delegate void SearchFieldCallback();
  }
}