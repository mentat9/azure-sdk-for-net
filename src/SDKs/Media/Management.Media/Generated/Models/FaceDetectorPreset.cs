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
    using System.Linq;

    /// <summary>
    /// Describes all the settings to be used when analyzing a video in order
    /// to detect all the faces present.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.FaceDetectorPreset")]
    public partial class FaceDetectorPreset : Preset
    {
        /// <summary>
        /// Initializes a new instance of the FaceDetectorPreset class.
        /// </summary>
        public FaceDetectorPreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceDetectorPreset class.
        /// </summary>
        /// <param name="resolution">Specifies the maximum resolution at which
        /// your video is analyzed. The default behavior is "SourceResolution,"
        /// which will keep the input video at its original resolution when
        /// analyzed. Using "StandardDefinition" will resize input videos to
        /// standard definition while preserving the appropriate aspect ratio.
        /// It will only resize if the video is of higher resolution. For
        /// example, a 1920x1080 input would be scaled to 640x360 before
        /// processing. Switching to "StandardDefinition" will reduce the time
        /// it takes to process high resolution video. It may also reduce the
        /// cost of using this component (see
        /// https://azure.microsoft.com/en-us/pricing/details/media-services/#analytics
        /// for details). However, faces that end up being too small in the
        /// resized video may not be detected. Possible values include:
        /// 'SourceResolution', 'StandardDefinition'</param>
        public FaceDetectorPreset(AnalysisResolution? resolution = default(AnalysisResolution?))
        {
            Resolution = resolution;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the maximum resolution at which your video
        /// is analyzed. The default behavior is "SourceResolution," which will
        /// keep the input video at its original resolution when analyzed.
        /// Using "StandardDefinition" will resize input videos to standard
        /// definition while preserving the appropriate aspect ratio. It will
        /// only resize if the video is of higher resolution. For example, a
        /// 1920x1080 input would be scaled to 640x360 before processing.
        /// Switching to "StandardDefinition" will reduce the time it takes to
        /// process high resolution video. It may also reduce the cost of using
        /// this component (see
        /// https://azure.microsoft.com/en-us/pricing/details/media-services/#analytics
        /// for details). However, faces that end up being too small in the
        /// resized video may not be detected. Possible values include:
        /// 'SourceResolution', 'StandardDefinition'
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public AnalysisResolution? Resolution { get; set; }

    }
}
