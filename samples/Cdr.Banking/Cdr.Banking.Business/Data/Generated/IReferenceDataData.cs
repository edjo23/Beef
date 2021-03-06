/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Business.Data
{
    /// <summary>
    /// Provides the <see cref="T:ReferenceData"/> database access.
    /// </summary>
    public partial interface IReferenceDataData
    {
        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.OpenStatus"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.OpenStatusCollection"/>.</returns>
        Task<RefDataNamespace.OpenStatusCollection> OpenStatusGetAllAsync();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.ProductCategory"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.ProductCategoryCollection"/>.</returns>
        Task<RefDataNamespace.ProductCategoryCollection> ProductCategoryGetAllAsync();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.AccountUType"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.AccountUTypeCollection"/>.</returns>
        Task<RefDataNamespace.AccountUTypeCollection> AccountUTypeGetAllAsync();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.MaturityInstructions"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.MaturityInstructionsCollection"/>.</returns>
        Task<RefDataNamespace.MaturityInstructionsCollection> MaturityInstructionsGetAllAsync();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.TransactionType"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.TransactionTypeCollection"/>.</returns>
        Task<RefDataNamespace.TransactionTypeCollection> TransactionTypeGetAllAsync();

        /// <summary>
        /// Gets all the <see cref="RefDataNamespace.TransactionStatus"/> objects.
        /// </summary>
        /// <returns>A <see cref="RefDataNamespace.TransactionStatusCollection"/>.</returns>
        Task<RefDataNamespace.TransactionStatusCollection> TransactionStatusGetAllAsync();
    }
}

#nullable restore