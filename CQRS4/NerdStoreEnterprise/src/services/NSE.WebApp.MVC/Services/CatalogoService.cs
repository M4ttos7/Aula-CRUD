﻿using Microsoft.Extensions.Options;
using NSE.WebApp.MVC.Extensions;
using NSE.WebApp.MVC.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Services
{
    public class CatalogoService : Service, ICatalogoService
    {
        private readonly HttpClient _httpClient;

        public CatalogoService(HttpClient httpCLient,
           IOptions<AppSettings> settings)
        {
            httpCLient.BaseAddress = new Uri(settings.Value.CatalogoUrl);

            _httpClient = httpCLient;
        }

        public async Task<ProdutoViewModel> ObterPorId(Guid id)
        {
            var response = await _httpClient.GetAsync($"/catalogo/produtos/{id}");
             
            TratarErrosResponse(response);

            return await DeserializarObjetoRsponse<ProdutoViewModel>(response);
        }

        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            var response = await _httpClient.GetAsync("/catalogo/produtos/");

            TratarErrosResponse(response);

            return await DeserializarObjetoRsponse<IEnumerable<ProdutoViewModel>>(response);

        }
    }
}