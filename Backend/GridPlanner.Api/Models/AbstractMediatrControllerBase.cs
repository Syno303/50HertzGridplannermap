using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GridPlanner.Backend.Models;

public class AbstractMediatrControllerBase : ControllerBase
{
    internal readonly IMediator Mediator;

    public AbstractMediatrControllerBase(IMediator mediator)
    {
        Mediator = mediator;
    }
    
}