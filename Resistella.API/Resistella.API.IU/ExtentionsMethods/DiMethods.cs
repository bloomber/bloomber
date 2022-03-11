using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediatR;
using Resistella.Core.Domaine.Repository;
using Resistella.Core.Domain;
using Resistella.Core.Infrastructures.Data.Repository;

namespace Resistella.API.IU.ExtentionsMethods
{
    public static class DiMethods
    {
        public static void AddInjections(this IServiceCollection services)
        {
            services.AddTransient(typeof(IArticleRepository<Article>), typeof(ArticleRepository));
            services.AddMediatR(typeof(Startup));
        }
    }
}
