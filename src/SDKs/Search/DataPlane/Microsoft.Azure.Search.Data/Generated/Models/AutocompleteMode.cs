// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutocompleteMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutocompleteMode
    {
        [EnumMember(Value = "oneTerm")]
        OneTerm,
        [EnumMember(Value = "twoTerms")]
        TwoTerms,
        [EnumMember(Value = "oneTermWithContext")]
        OneTermWithContext
    }
    internal static class AutocompleteModeEnumExtension
    {
        internal static string ToSerializedValue(this AutocompleteMode? value)
        {
            return value == null ? null : ((AutocompleteMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutocompleteMode value)
        {
            switch( value )
            {
                case AutocompleteMode.OneTerm:
                    return "oneTerm";
                case AutocompleteMode.TwoTerms:
                    return "twoTerms";
                case AutocompleteMode.OneTermWithContext:
                    return "oneTermWithContext";
            }
            return null;
        }

        internal static AutocompleteMode? ParseAutocompleteMode(this string value)
        {
            switch( value )
            {
                case "oneTerm":
                    return AutocompleteMode.OneTerm;
                case "twoTerms":
                    return AutocompleteMode.TwoTerms;
                case "oneTermWithContext":
                    return AutocompleteMode.OneTermWithContext;
            }
            return null;
        }
    }
}
