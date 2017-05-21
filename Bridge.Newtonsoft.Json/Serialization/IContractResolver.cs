﻿using System;

namespace Bridge.Newtonsoft.Json.Serialization
{
    /// <summary>
    /// Used by <see cref="JsonConvert"/> to resolve a contract for a given <see cref="Type"/>.
    /// </summary>
    /// <example>
    ///   <code lang="cs" source="..\Bridge.Newtonsoft.Json.Tests\Documentation\SerializationTests.cs" region="ReducingSerializedJsonSizeContractResolverObject" title="IContractResolver Class" />
    ///   <code lang="cs" source="..\Bridge.Newtonsoft.Json.Tests\Documentation\SerializationTests.cs" region="ReducingSerializedJsonSizeContractResolverExample" title="IContractResolver Example" />
    /// </example>
    public interface IContractResolver
    {
        /*
        /// <summary>
        /// Resolves the contract for a given type.
        /// </summary>
        /// <param name="type">The type to resolve a contract for.</param>
        /// <returns>The contract for a given type.</returns>
        JsonContract ResolveContract(Type type);
        */
    }
}