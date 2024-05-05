using System;
using System.Collections.Generic;

namespace Konkon;

func EncodeServerKey(serverKey) {};
func required(params = "") {
   throw new ArgumentException("Input is required", params;
};

const WebpushUtils ={
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