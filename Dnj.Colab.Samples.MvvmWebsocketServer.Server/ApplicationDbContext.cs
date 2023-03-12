using Dnj.Colab.Samples.MvvmWebSocketServer.Identity.RCL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dnj.Colab.Samples.MvvmWebsocketServer.Server;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
}
