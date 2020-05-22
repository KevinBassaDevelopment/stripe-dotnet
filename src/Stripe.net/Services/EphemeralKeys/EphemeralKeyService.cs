namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public class EphemeralKeyService : Service<EphemeralKey>,
        ICreatable<EphemeralKey, EphemeralKeyCreateOptions>,
        IDeletable<EphemeralKey, EphemeralKeyDeleteOptions>
    {
        public EphemeralKeyService()
            : base(null)
        {
        }

        public EphemeralKeyService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/ephemeral_keys";

        public virtual EphemeralKey Create(EphemeralKeyCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<EphemeralKey> CreateAsync(EphemeralKeyCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual EphemeralKey Delete(string id, EphemeralKeyDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, options, requestOptions);
        }

        public virtual Task<EphemeralKey> DeleteAsync(string id, EphemeralKeyDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
