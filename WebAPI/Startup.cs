using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerDocument();

            services.AddSingleton<IAuthService, AuthManager>();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, EfUserDal>();
            services.AddSingleton<IBookService, BookManager>();
            services.AddSingleton<IBookDal, EfBookDal>();
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<IAuthorService, AuthorManager>();
            services.AddSingleton<IAuthorDal, EfAuthorDal>();
            services.AddSingleton<IPublisherService, PublisherManager>();
            services.AddSingleton<IPublisherDal, EfPublisherDal>();
            services.AddSingleton<ISubcategoryService, SubcategoryManager>();
            services.AddSingleton<ISubcategoryDal, EfSubcategoryDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//gelen requetteki url in hangi rout ile eþleþtiðini belirliyor.
            app.UseOpenApi();
            app.UseSwaggerUi3();
            //end pointte bu routun çalýþmasýný saðlýyor.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
