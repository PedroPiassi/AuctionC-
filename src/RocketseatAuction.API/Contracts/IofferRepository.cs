using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IofferRepository
{
    void Add(Offer offer);
}
