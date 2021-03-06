/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Microsoft.Azure.Cosmos;
using Beef.Data.Cosmos;
using Beef.Entities;
using Beef.Mapper;
using Beef.Mapper.Converters;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Provides the Robot data access.
    /// </summary>
    public partial class RobotData : IRobotData
    {
        #region Private
        #pragma warning disable CS0649 // Defaults to null by design; can be overridden in constructor.

        private readonly Action<ICosmosDbArgs>? _onDataArgsCreate;

        private readonly Func<Guid, ICosmosDbArgs, Task>? _getOnBeforeAsync;
        private readonly Func<Robot?, Guid, Task>? _getOnAfterAsync;
        private readonly Action<Exception>? _getOnException;

        private readonly Func<Robot, ICosmosDbArgs, Task>? _createOnBeforeAsync;
        private readonly Func<Robot, Task>? _createOnAfterAsync;
        private readonly Action<Exception>? _createOnException;

        private readonly Func<Robot, ICosmosDbArgs, Task>? _updateOnBeforeAsync;
        private readonly Func<Robot, Task>? _updateOnAfterAsync;
        private readonly Action<Exception>? _updateOnException;

        private readonly Func<Guid, ICosmosDbArgs, Task>? _deleteOnBeforeAsync;
        private readonly Func<Guid, Task>? _deleteOnAfterAsync;
        private readonly Action<Exception>? _deleteOnException;

        private readonly Func<IQueryable<Model.Robot>, RobotArgs?, ICosmosDbArgs, IQueryable<Model.Robot>>? _getByArgsOnQuery;
        private readonly Func<RobotArgs?, ICosmosDbArgs, Task>? _getByArgsOnBeforeAsync;
        private readonly Func<RobotCollectionResult, RobotArgs?, Task>? _getByArgsOnAfterAsync;
        private readonly Action<Exception>? _getByArgsOnException;

        #pragma warning restore CS0649
        #endregion

        /// <summary>
        /// Gets the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <returns>The selected <see cref="Robot"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<Robot?> GetAsync(Guid id)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Robot? __result;
                var __dataArgs = CosmosMapper.Default.CreateArgs("Items", PartitionKey.None);
                _onDataArgsCreate?.Invoke(__dataArgs);
                if (_getOnBeforeAsync != null) await _getOnBeforeAsync(id, __dataArgs).ConfigureAwait(false);
                __result = await CosmosDb.Default.Container(__dataArgs).GetAsync(id).ConfigureAwait(false);
                if (_getOnAfterAsync != null) await _getOnAfterAsync(__result, id).ConfigureAwait(false);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getOnException });
        }

        /// <summary>
        /// Creates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <returns>A refreshed <see cref="Robot"/> object.</returns>
        public Task<Robot> CreateAsync(Robot value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Robot __result;
                var __dataArgs = CosmosMapper.Default.CreateArgs("Items", PartitionKey.None);
                _onDataArgsCreate?.Invoke(__dataArgs);
                if (_createOnBeforeAsync != null) await _createOnBeforeAsync(value, __dataArgs).ConfigureAwait(false);
                __result = await CosmosDb.Default.Container(__dataArgs).CreateAsync(value).ConfigureAwait(false);
                if (_createOnAfterAsync != null) await _createOnAfterAsync(__result).ConfigureAwait(false);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _createOnException });
        }

        /// <summary>
        /// Updates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <returns>A refreshed <see cref="Robot"/> object.</returns>
        public Task<Robot> UpdateAsync(Robot value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Robot __result;
                var __dataArgs = CosmosMapper.Default.CreateArgs("Items", PartitionKey.None);
                _onDataArgsCreate?.Invoke(__dataArgs);
                if (_updateOnBeforeAsync != null) await _updateOnBeforeAsync(value, __dataArgs).ConfigureAwait(false);
                __result = await CosmosDb.Default.Container(__dataArgs).UpdateAsync(value).ConfigureAwait(false);
                if (_updateOnAfterAsync != null) await _updateOnAfterAsync(__result).ConfigureAwait(false);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _updateOnException });
        }

        /// <summary>
        /// Deletes the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        public Task DeleteAsync(Guid id)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                var __dataArgs = CosmosMapper.Default.CreateArgs("Items", PartitionKey.None);
                _onDataArgsCreate?.Invoke(__dataArgs);
                if (_deleteOnBeforeAsync != null) await _deleteOnBeforeAsync(id, __dataArgs).ConfigureAwait(false);
                await CosmosDb.Default.Container(__dataArgs).DeleteAsync(id).ConfigureAwait(false);
                if (_deleteOnAfterAsync != null) await _deleteOnAfterAsync(id).ConfigureAwait(false);
            }, new BusinessInvokerArgs { ExceptionHandler = _deleteOnException });
        }

        /// <summary>
        /// Gets the <see cref="Robot"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="RobotArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="RobotCollectionResult"/>.</returns>
        public Task<RobotCollectionResult> GetByArgsAsync(RobotArgs? args, PagingArgs? paging)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                RobotCollectionResult __result = new RobotCollectionResult(paging);
                var __dataArgs = CosmosMapper.Default.CreateArgs("Items", __result.Paging!, PartitionKey.None);
                _onDataArgsCreate?.Invoke(__dataArgs);
                if (_getByArgsOnBeforeAsync != null) await _getByArgsOnBeforeAsync(args, __dataArgs).ConfigureAwait(false);
                __result.Result = CosmosDb.Default.Container(__dataArgs).Query(q => _getByArgsOnQuery == null ? q : _getByArgsOnQuery(q, args, __dataArgs)).SelectQuery<RobotCollection>();
                if (_getByArgsOnAfterAsync != null) await _getByArgsOnAfterAsync(__result, args).ConfigureAwait(false);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getByArgsOnException });
        }

        /// <summary>
        /// Provides the <see cref="Robot"/> entity and Cosmos <see cref="Model.Robot"/> property mapping.
        /// </summary>
        public partial class CosmosMapper : CosmosDbMapper<Robot, Model.Robot, CosmosMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CosmosMapper"/> class.
            /// </summary>
            public CosmosMapper()
            {
                Property(s => s.Id, d => d.Id).SetUniqueKey(true);
                Property(s => s.ModelNo, d => d.ModelNo);
                Property(s => s.SerialNo, d => d.SerialNo);
                Property(s => s.EyeColorSid, d => d.EyeColor);
                Property(s => s.PowerSourceSid, d => d.PowerSource);
                AddStandardProperties();
                CosmosMapperCtor();
            }
            
            /// <summary>
            /// Enables the <see cref="CosmosMapper"/> constructor to be extended.
            /// </summary>
            partial void CosmosMapperCtor();
        }
    }
}

#nullable restore