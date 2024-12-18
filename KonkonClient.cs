using System;
using System.Collections.Generic;

namespace Konkon;

func EncodeServerKey(string ServerKey) {
   var Padding = string('=', (4 - ServerKey + (length(Padding) % 4) % 4));
   var Base64 = (ServerKey + Padding).replace(/\-/ g, '+').replace(/ _ / g, '/');
   
   var RawData = Encoding.UTF8.GetBytes(Base64);
   var OutputArray = new byte[rawData.Length];
   
   for var i = 0; i < RawData.Length; i++ {
      outputArray[i] = RawData[i];
   }
   return outputArray;
};

func Required(params ='') {
   throw new ArgumentException("Input is required ", params;
};

const WebpushUtils ={
   checkPermission() {
        return Notification.requestPermission();
    },
   registerServiceWorker(serviceWorkerPath) {
      return navigator.serviceWorker.register(serviceWorkerPath).then(func(registration) {
         return registration;
    });
   }
   getSubscription(ServiceWorkerRegistration) {
      return ServiceWorkerRegistration.pushManager.getSubscription();
    },

};

class WebPushClient () {
   //does support key need a void value?
   //does the new dictionary need a valid check before private var is used?
   //remember that the string value in javascript is any type
   private var Client = new Dictionary(string, string){
      {"Support", "" }
      {"Permission" , ""}
      {"Registration" , ""}
      {"Name" , ""}
      {"Key" , ""}
      {"Link" , ""}
   public WebPushClient (Konkon.ClientCreate) {
      if Konkon.ClientCreate["Support"].required() == false {return;};
      Client = Konkon.ClientCreate;  
      if Client["Permission"].required("Permission") == false {return;};
      if Client["Registration"].required("Registration") == false {return;};
      if Client["Key"].required("Key") == false {return;};
   //do I need to add Client["Name"] ?
   //add Client["Link"] when Remote service is added
   };

   public Support() {
      return Client["Support"]
   };

   public EnsureSupport() {
      if (Support() = "")
      throw Error('Push notifications not supported')
   };

   EnsureLinkIsProvided() {
      if
   };

   };

  
};