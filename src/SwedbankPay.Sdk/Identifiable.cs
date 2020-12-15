﻿using System;

namespace SwedbankPay.Sdk
{
    /// <summary>
    /// Contains a <seealso cref="Uri"/> to a uniquely identifiable resource.
    /// </summary>
    public class Identifiable
    {
        /// <summary>
        /// Instantiates and sets the <see cref="Id"/> of the <see cref="Identifiable"/>.
        /// </summary>
        /// <param name="id">The unique ID of this resource.</param>
        public Identifiable(Uri id)
        {
            Id = id;
        }

        /// <summary>
        ///     Relative URL to the resource
        /// </summary>
        public Uri Id { get; }
    }
}