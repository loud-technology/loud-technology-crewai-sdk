
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.Error? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationError? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationErrorDetails? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ExecutionStatus? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionRequest? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionRequest? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.GetRequiredInputsResponse? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponse? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponseStatus? Type14 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
    }
}