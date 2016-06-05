using System;
using PunClient.PunWebService;


namespace PunClient.DataServices
{
    public class PunDataService
    {
        private readonly PunServicev10SoapClient _client;

        public PunDataService()
        {
            _client = new PunWebService.PunServicev10SoapClient();
        }

        public Pun[] GetPuns()
        {
            return _client.GetPuns();
        }

        public Pun GetPunById(int punId)
        {
            return _client.GetPunById(punId);
        }

        public void CreatePun(Pun pun)
        {
            _client.CreatePun(pun);
        }

        public void UpdatePun(Pun pun)
        {
            
        }

        public void DeletePun(int punId)
        {
            _client.DeletePun(punId);
        }
    }


}
