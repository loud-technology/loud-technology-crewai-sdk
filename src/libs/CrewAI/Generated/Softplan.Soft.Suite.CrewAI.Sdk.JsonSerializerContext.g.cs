
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.JsonConverters.ResumeCrewExecutionResponseStatusJsonConverter),

            typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.JsonConverters.ResumeCrewExecutionResponseStatusNullableJsonConverter),

            typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.ExecutionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.GetRequiredInputsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponseStatus), TypeInfoPropertyName = "ResumeCrewExecutionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}