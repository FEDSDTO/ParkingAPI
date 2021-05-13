using ParkingAPI.Models;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace ParkingAPI.App_Code
{
    public class Func_Public
    {
        //Prod
        //string _urlA = "https://10.32.101.21:2443/apppayment/api/", _token = "0858f0fb2ea92e69b6db";
        //string _urlD = "https://10.32.101.21:2443/discount-center/api/app/";
        //string _urlS = "https://10.32.101.21/space/api/";
        string _urlC = "http://csc.ichenparking.com.tw/api/v1/cars?API_key=HQtsESwVWu9U7S8VisJKFK0vmQeS3rXGGKVw&Park_ID=PSS_IC0017&Plate=";

        //Test
        string _urlA = "http://office-tku.ichenparking.com.tw:2100/app/api/", _token = "a496597e43f94cfbb83e";
        string _urlD = "http://office-tku.ichenparking.com.tw:2100/discount-center/api/app/";
        string _urlS = "https://office-tku.ichenparking.com.tw/space/api/";

        //查詢入車資訊
        public object Parking_query_car_info(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlA + "query_car_info");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //試算金額
        public object Parking_trial_calculate_fee(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlA + "trial_calculate_fee");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //計價
        public object Parking_fee(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlA + "fee");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //取得發票號碼
        public object Parking_get_electronic_receipt_number(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlA + "get_electronic_receipt_number");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //寫帳
        public object Parking_record_transaction_detail(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlA + "record_transaction_detail");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //登錄消費資訊
        public object Parking_attach_consumption(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlD + "attach_consumption");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //分拆消費登錄API
        public object Parking_attach_splited_consumption(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlD + "attach_splited_consumption");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //刪除消費補登API
        public object Parking_delete_consumption(object _Prop)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlD + "delete_consumption");
            request.Headers.Set("X-APP-TOKEN", _token);
            request.ContentType = "application/json";
            request.Method = "POST";

            var serializer = new JavaScriptSerializer();
            var jsonObject = serializer.Deserialize<object>(_Prop.ToString());
            var jsonText = serializer.Serialize(jsonObject);
            byte[] payload = Encoding.UTF8.GetBytes(jsonText);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //查詢剩餘車位(原)
        public object Parking_get_remain_space_info()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlS + "get_remain_space_info");
            request.ContentType = "application/json";
            request.Method = "GET";

            var serializer = new JavaScriptSerializer();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //查詢剩餘車位(新)
        public object Parking_get_space_info()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlS + "get_space_info");
            request.ContentType = "application/json";
            request.Method = "GET";

            var serializer = new JavaScriptSerializer();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }

        //查詢車格位置
        public object Parking_cars(object _Prop)
        {
            CarsProp carsProp = new CarsProp();
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            object _response;

            var serializer = new JavaScriptSerializer();
            CarsProp jsonObject = serializer.Deserialize<CarsProp>(_Prop.ToString());

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_urlC + jsonObject.Plate);
            request.ContentType = "application/json";
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                _response = serializer.Deserialize<object>(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                _response = "Error";
            }
            finally
            {
                reader.Close();
                stream.Close();
                response.Close();
            }
            return _response;
        }
    }
}