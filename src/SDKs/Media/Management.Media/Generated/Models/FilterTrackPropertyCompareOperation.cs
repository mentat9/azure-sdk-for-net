// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for FilterTrackPropertyCompareOperation.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(FilterTrackPropertyCompareOperationConverter))]
    public struct FilterTrackPropertyCompareOperation : System.IEquatable<FilterTrackPropertyCompareOperation>
    {
        private FilterTrackPropertyCompareOperation(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The equal operation.
        /// </summary>
        public static readonly FilterTrackPropertyCompareOperation Equal = "Equal";

        /// <summary>
        /// The not equal operation.
        /// </summary>
        public static readonly FilterTrackPropertyCompareOperation NotEqual = "NotEqual";


        /// <summary>
        /// Underlying value of enum FilterTrackPropertyCompareOperation
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for
        /// FilterTrackPropertyCompareOperation
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type FilterTrackPropertyCompareOperation
        /// </summary>
        public bool Equals(FilterTrackPropertyCompareOperation e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// FilterTrackPropertyCompareOperation
        /// </summary>
        public static implicit operator FilterTrackPropertyCompareOperation(string value)
        {
            return new FilterTrackPropertyCompareOperation(value);
        }

        /// <summary>
        /// Implicit operator to convert FilterTrackPropertyCompareOperation to
        /// string
        /// </summary>
        public static implicit operator string(FilterTrackPropertyCompareOperation e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum FilterTrackPropertyCompareOperation
        /// </summary>
        public static bool operator == (FilterTrackPropertyCompareOperation e1, FilterTrackPropertyCompareOperation e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum FilterTrackPropertyCompareOperation
        /// </summary>
        public static bool operator != (FilterTrackPropertyCompareOperation e1, FilterTrackPropertyCompareOperation e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for FilterTrackPropertyCompareOperation
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is FilterTrackPropertyCompareOperation && Equals((FilterTrackPropertyCompareOperation)obj);
        }

        /// <summary>
        /// Returns for hashCode FilterTrackPropertyCompareOperation
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
