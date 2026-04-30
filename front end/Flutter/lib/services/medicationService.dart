

import 'dart:convert';
import 'package:http/http.dart' as http;
import '../models/medication.dart';

class MedicationService {
  static const String API_URL='http://10.0.2.2:5275/v1/medications';
  static Future<List<Medication>> getMedications() async{
    final response= await http.get(Uri.parse(API_URL));
    if (response.statusCode==200){
      List data=jsonDecode(response.body);
      return data.map((e)=>Medication.fromJson(e)).toList();
    }
    else{
      throw Exception("Error while loading medications ${response.body}");

    }
  }
  static Future<void> addMedication(Medication m) async{
    final response=await http.post(
      Uri.parse(API_URL),
      headers: {
        'Content-Type': 'application/json'
      },
      body: jsonEncode(m.toJson())
    );
    if (response.statusCode!=200 && response.statusCode!=201){
      throw Exception("Error while adding medication ${response.body}");
    }
  }

  static Future<void> updateMedication(Medication m) async{
    final int? medicationId=m.Id;
    print(medicationId);
    final response=await http.put(
        Uri.parse('$API_URL/$medicationId'),
        headers: {
          'Content-Type': 'application/json'
        },
        body: jsonEncode(m.toJson())
    );
    if (response.statusCode!=200){
      throw Exception('Error while updating medication ${response.body}');
    }
  }

  static Future<void> deleteMedication(Medication m) async{
    final int? medicationId=m.Id;
    final response=await http.delete(
        Uri.parse('$API_URL/$medicationId'),
        headers: {
          'Content-Type': 'application/json'
        }
    );
    if (response.statusCode!=204){
      throw Exception("Error while deleting medication ${response.body}");
    }
  }



}