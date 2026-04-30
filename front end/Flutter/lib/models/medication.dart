class Medication {
  final int? Id;
  final String name;
  final String type;
  final String description;
  final String? sideEffects;
  Medication({
    required this.Id,
    required this.name,
    required this.type,
    required this.description,
    required this.sideEffects,
  });
  factory Medication.fromJson(Map<String,dynamic> json){
    return Medication(
      Id: json['id'],
      name: json['name'],
      type: json['type'],
      description: json['description'],
      sideEffects: json['sideEffects'],

    );
  }
  Map<String, dynamic> toJson(){
    return{
      'name': name,
      'description': description,
      'type': type,
      'sideEffects': sideEffects,
    };
  }
}