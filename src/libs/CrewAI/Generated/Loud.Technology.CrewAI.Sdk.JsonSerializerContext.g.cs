
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Loud.Technology.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Loud.Technology.CrewAI.Sdk.JsonConverters.ResumeCrewExecutionResponseStatusJsonConverter),

            typeof(global::Loud.Technology.CrewAI.Sdk.JsonConverters.ResumeCrewExecutionResponseStatusNullableJsonConverter),

            typeof(global::Loud.Technology.CrewAI.Sdk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.ValidationErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.ExecutionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.StartCrewExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.GetRequiredInputsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.StartCrewExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponseStatus), TypeInfoPropertyName = "ResumeCrewExecutionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}