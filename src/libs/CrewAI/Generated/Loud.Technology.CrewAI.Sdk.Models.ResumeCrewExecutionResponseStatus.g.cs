
#nullable enable

namespace Loud.Technology.CrewAI.Sdk
{
    /// <summary>
    /// Status of the resumed execution<br/>
    /// Example: resumed
    /// </summary>
    public enum ResumeCrewExecutionResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Resumed,
        /// <summary>
        ///
        /// </summary>
        Retrying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResumeCrewExecutionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResumeCrewExecutionResponseStatus value)
        {
            return value switch
            {
                ResumeCrewExecutionResponseStatus.Completed => "completed",
                ResumeCrewExecutionResponseStatus.Resumed => "resumed",
                ResumeCrewExecutionResponseStatus.Retrying => "retrying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResumeCrewExecutionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResumeCrewExecutionResponseStatus.Completed,
                "resumed" => ResumeCrewExecutionResponseStatus.Resumed,
                "retrying" => ResumeCrewExecutionResponseStatus.Retrying,
                _ => null,
            };
        }
    }
}