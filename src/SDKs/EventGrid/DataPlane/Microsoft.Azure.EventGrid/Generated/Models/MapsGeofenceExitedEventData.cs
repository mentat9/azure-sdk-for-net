// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a
    /// Microsoft.Maps.GeofenceExited event.
    /// </summary>
    public partial class MapsGeofenceExitedEventData : MapsGeofenceEventProperties
    {
        /// <summary>
        /// Initializes a new instance of the MapsGeofenceExitedEventData
        /// class.
        /// </summary>
        public MapsGeofenceExitedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapsGeofenceExitedEventData
        /// class.
        /// </summary>
        /// <param name="expiredGeofenceGeometryId">Lists of the geometry ID of
        /// the geofence which is expired relative to the user time in the
        /// request.</param>
        /// <param name="geometries">Lists the fence geometries that either
        /// fully contain the coordinate position or have an overlap with the
        /// searchBuffer around the fence.</param>
        /// <param name="invalidPeriodGeofenceGeometryId">Lists of the geometry
        /// ID of the geofence which is in invalid period relative to the user
        /// time in the request.</param>
        /// <param name="isEventPublished">True if at least one event is
        /// published to the Azure Maps event subscriber, false if no event is
        /// published to the Azure Maps event subscriber.</param>
        public MapsGeofenceExitedEventData(IList<string> expiredGeofenceGeometryId = default(IList<string>), IList<MapsGeofenceGeometry> geometries = default(IList<MapsGeofenceGeometry>), IList<string> invalidPeriodGeofenceGeometryId = default(IList<string>), bool? isEventPublished = default(bool?))
            : base(expiredGeofenceGeometryId, geometries, invalidPeriodGeofenceGeometryId, isEventPublished)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
