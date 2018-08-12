using System;
using System.Collections.Generic;
using System.Reflection;

namespace Alice.NET.Attributes
{
    public static class ReflectionHelper
    {
        /// <summary>
		/// Возвращает зависимые сборки с тем же CompanyName (первая часть имени сборки).
		/// </summary>
		public static ISet<Assembly> GetApplicationAssemblies(this Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            // https://msdn.microsoft.com/en-us/library/ms229048(v=vs.110).aspx
            var assemblyNamePrefix = GetAppName(assembly.FullName);

            var assemblies = new HashSet<Assembly>();
            FillApplicationAssemblies(assembly, assemblies, assemblyNamePrefix);
            return assemblies;
        }

        private static void FillApplicationAssemblies(Assembly assembly, ISet<Assembly> assemblies, string assemblyNamePrefix)
        {
            if (!assemblies.Add(assembly))
                return;

            foreach (var referencedAssemblyName in assembly.GetReferencedAssemblies())
                if (referencedAssemblyName.FullName.StartsWith(assemblyNamePrefix, StringComparison.Ordinal))
                    FillApplicationAssemblies(Assembly.Load(referencedAssemblyName), assemblies, assemblyNamePrefix);
        }

        private static string GetAppName(string fullName)
        {
            var index = fullName.IndexOf('.');
            if (index < 0)
                throw new ArgumentException();

            var prefix = fullName.Substring(0, index);
            return prefix;
        }

        /// <summary>
        /// Возвращает атрибут заданного типа <typeparamref name="T"/>, которым помечен указанный тип <paramref name="type"/>, или null в случае отсутствия.
        /// </summary>
        public static T GetAttribute<T>(this MemberInfo type, bool inherit = false)
            where T : Attribute
        {
            return (T)Attribute.GetCustomAttribute(type, typeof(T), inherit);
        }

        public static bool TryGetAttribute<T>(this MemberInfo type, out T attribute, bool inherit = false)
            where T : Attribute
        {
            attribute = GetAttribute<T>(type);
            return attribute == null ? false : true;
        }

        public static bool IsInheritInterface(this Type type, string interfaceName)
        {
            return type.GetInterface(interfaceName) == null ? false : true;
        }

        public static T CreateObject<T>(this Type type)
            where T : class
        {
            return (T)Activator.CreateInstance(type);
        }
    }
}
