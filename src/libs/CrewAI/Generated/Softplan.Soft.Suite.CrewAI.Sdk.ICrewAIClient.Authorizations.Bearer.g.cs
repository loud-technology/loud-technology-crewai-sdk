
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    public partial interface ICrewAIClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}