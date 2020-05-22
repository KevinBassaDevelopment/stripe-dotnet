namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SourceService : Service<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source, SourceGetOptions>,
        IUpdatable<Source, SourceUpdateOptions>
    {
        public SourceService()
            : base(null)
        {
        }

        public SourceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/sources";

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual unknown Detach(string id, SourceDetachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<unknown>(HttpMethod.Delete, /v1/customers/{customer}/sources/{id}, options, requestOptions);
        }

        public virtual Task<unknown> DetachAsync(string id, SourceDetachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<unknown>(HttpMethod.Delete, /v1/customers/{customer}/sources/{id}, options, requestOptions, cancellationToken);
        }

        public virtual Source Get(string sourceId, SourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(sourceId, options, requestOptions);
        }

        public virtual Task<Source> GetAsync(string sourceId, SourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(sourceId, options, requestOptions, cancellationToken);
        }

        public virtual ApmsSourcesSourceTransactionList SourceTransactions(string id, SourceSourceTransactionsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApmsSourcesSourceTransactionList>(HttpMethod.Get, $"{this.InstanceUrl(id)}/source_transactions", options, requestOptions);
        }

        public virtual Task<ApmsSourcesSourceTransactionList> SourceTransactionsAsync(string id, SourceSourceTransactionsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApmsSourcesSourceTransactionList>(HttpMethod.Get, $"{this.InstanceUrl(id)}/source_transactions", options, requestOptions, cancellationToken);
        }

        public virtual Source Update(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(sourceId, options, requestOptions);
        }

        public virtual Task<Source> UpdateAsync(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(sourceId, options, requestOptions, cancellationToken);
        }

        public virtual Source Verify(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions);
        }

        public virtual Task<Source> VerifyAsync(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
