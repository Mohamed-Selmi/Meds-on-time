

import 'dart:convert';
import 'package:http/http.dart' as http;
import '../models/user.dart';

class UserService{

  static const String API_URL='http://10.0.2.2:5275/v1/users';

  static Future<List<User>> getUsers() async{
    final response= await http.get(Uri.parse(API_URL));
    if (response.statusCode==200){
      List data=jsonDecode(response.body);
      return data.map((e)=>User.fromJson(e)).toList();
    }
    else{
      throw Exception("Error while loading Users ${response.body}");

    }
  }
  static Future<void> addUser(User u) async{
    final response=await http.post(
        Uri.parse(API_URL),
        headers: {
          'Content-Type': 'application/json'
        },
        body: jsonEncode(u.toJson())
    );
    if (response.statusCode!=200 && response.statusCode!=201){
      throw Exception("Error while adding User ${response.body}");
    }
  }

  static Future<void> updateUser(User u) async{
    final int? userId=u.Id;
    final response=await http.put(
        Uri.parse('$API_URL/$userId'),
        headers: {
          'Content-Type': 'application/json'
        }
    );
    if (response.statusCode!=200){
      throw Exception("Error while updating User ${response.body}");
    }
  }

  static Future<void> deleteUser(User u) async{
    final int? userId=u.Id;
    final response=await http.delete(
        Uri.parse('$API_URL/$userId'),
        headers: {
          'Content-Type': 'application/json'
        }
    );
    if (response.statusCode!=204){
      throw Exception("Error while deleting User ${response.body}");
    }
  }
  
  
  
  
  
  
  
  
  
  
}