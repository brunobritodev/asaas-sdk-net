﻿using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Transfer;
using AsaasClient.Models.Transfer.Base;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class TransferManager : BaseManager
    {
        private const string TRANSFERS_URL = "/transfers";

        public TransferManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseList<BaseTransfer>> List(int offset, int limit, TransferListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            var responseList = await GetListAsync<BaseTransfer>(TRANSFERS_URL, offset, limit, queryMap);

            return responseList;
        }

        public async Task<ResponseObject<AsaasAccountTransfer>> Execute(AsaasAccountTransferRequest requestObj)
        {
            var responseObject = await PostAsync<AsaasAccountTransfer>(TRANSFERS_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<BankAccountTransfer>> Execute(BankAccountTransferRequest requestObj)
        {
            var responseObject = await PostAsync<BankAccountTransfer>(TRANSFERS_URL, requestObj);

            return responseObject;
        }
    }
}
