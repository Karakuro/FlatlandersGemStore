﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Http.Description;
using FlatlandersGemStore.Entities.Entities;
using FlatlandersGemStore.BL;

namespace FlatlandersGemStore.Controllers.Api
{
    /// <summary>
    /// Riceve le chiamate dalla Index
    /// </summary>
    [RoutePrefix("gem")]
    public class GemInventoryController : ApiController
    {
        public static GemInventoryManager manager;
        /// <summary>
        /// Richiede la lista completa delle gemme in vendita
        /// </summary>
        /// <returns></returns>
        [Route("getAll")]
        [HttpGet]
        public List<Gem> Get()
        {
            try
            {
                if (manager == null)
                    manager = new GemInventoryManager();
                return manager.GetAllInventory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// richiede i dettagli di una singola gemma
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("get/{id}")]
        [HttpGet]
        public Gem Get(string id)
        {
            try
            {
                if (manager == null)
                    manager = new GemInventoryManager();
                return manager.GetSingleGem(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Registra l'arrivo di un nuovo carico di gemme
        /// </summary>
        /// <returns></returns>
        [Route("insert")]
        [HttpPost]
        public bool Post()
        {
            try
            {
                if (manager == null)
                    manager = new GemInventoryManager();
                manager.StoreNewGems();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        /// <summary>
        /// Vende (rimuovendola dall'inventario) una singola gemma
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("deleteGem")]
        [HttpPost]
        public bool Post([FromBody] string name)
        {
            bool retVal = false;
            try
            {
                if (manager == null)
                    manager = new GemInventoryManager();

                retVal = manager.SellSingleGem(name);
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}