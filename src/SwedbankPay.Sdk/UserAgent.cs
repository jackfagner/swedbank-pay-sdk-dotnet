using System.Linq;
using System.Reflection;

namespace SwedbankPay.Sdk
{
    /// <summary>
    /// </summary>
    public static class UserAgent
    {
        /// <summary>
        /// Default UserAgent for HttpClient requests
        /// </summary>
        public static string Default { get; }
        static UserAgent()
        {
            Default = $"swedbankpay-sdk-dotnet/{Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version}";
        }
    }
}
