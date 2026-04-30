import 'package:flutter/material.dart';
import 'package:medsontime/screens/medicationform.dart';
import '../widgets/drawerWidget.dart';

import '../models/medication.dart';
import '../services/medicationService.dart';
class MedicationPage extends StatefulWidget {
  const MedicationPage({super.key});

  @override
  State<MedicationPage> createState() => _MedicationPageState();
}

class _MedicationPageState extends State<MedicationPage> {
  List<Medication> medications=[];
  @override
  void initState(){
    super.initState();
    loadMedications();
  }
  Future<void> loadMedications() async{
    final data=await MedicationService.getMedications();
    setState(() {
      medications=data;
    });
  }
  Future<void> deleteMedication(Medication m) async{
    try{
      await MedicationService.deleteMedication(m);
      loadMedications();
    }
    catch (e){
      debugPrint(e.toString());
    }
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
    drawer: MyDrawer(

    ),
    appBar: AppBar(title: Text('Medications',
    ),
      actions: <Widget>[
        IconButton(onPressed: ()=>{
    Navigator.of(context).pop(),
    Navigator.pushNamed(context,"/medicationsForm")
    }, icon: const Icon(Icons.add))
      ]
      ,
    backgroundColor: Colors.red,),
    body: medications.isEmpty ? const Center(child: Text('No medications found'),)
        :
        ListView.builder(
            itemCount: medications.length,
            itemBuilder: (context,index){
              final m=medications[index];
              return ListTile(

                title: Text('name: ${m.name} \n type: ${m.type}'),
                subtitle: Text(m.description),
                trailing: Row(
                  mainAxisSize: MainAxisSize.min,

                  children: [
                    IconButton(onPressed: ()=> {
                      Navigator.of(context).pop(),
                      Navigator.push(context, MaterialPageRoute(builder: (context)=>MedicationFormScreen(medication: m,)))
                    }, icon: const Icon(Icons.update)),
                    IconButton(onPressed: ()=>deleteMedication(m), icon: const Icon(Icons.delete)),
                    IconButton(onPressed: ()=>null, icon: const Icon(Icons.arrow_forward_sharp)),

                  ],

                ),
              );

            }

            ),

    );
  }
}

/*
class MedicationCard extends StatelessWidget {
  const MedicationCard({
    super.key,
    required this.nameField,
    required this.typeField,
    required this.descriptionField,
    required this.sideEffectsField,
  });
  final String nameField;
  final String typeField;
  final String descriptionField;
  final String sideEffectsField;

  @override
  Widget build(BuildContext context) {
    return Padding(padding: EdgeInsets.symmetric(vertical: 5.0),
    child: Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        Text('name: $nameField'),
        const Padding(padding: EdgeInsets.symmetric(vertical: 1.0)),
        Text('type: $typeField'),
        const Padding(padding: EdgeInsets.symmetric(vertical: 1.0)),
        Text('description: $descriptionField'),
        const Padding(padding: EdgeInsets.symmetric(vertical: 1.0)),
        Text('side Effects: $sideEffectsField'),
      ],
    ),);
  }
}

class CustomListItem extends StatelessWidget {
  const CustomListItem({
    super.key,
    required this.nameField,
    required this.typeField,
    required this.descriptionField,
    required this.sideEffectsField,
  });

  final String nameField;
  final String typeField;
  final String descriptionField;
  final String sideEffectsField;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 5.0),
      child: Row(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: <Widget>[
          Expanded(
            flex: 3,
            child: _MedicationDescription(
              nameField: nameField,
              typeField: typeField,
              descriptionField: descriptionField,
              sideEffectsField: sideEffectsField,
            ),
          ),
          const Icon(Icons.more_vert, size: 16.0),
        ],
      ),
    );
  }
}

class _MedicationDescription extends StatelessWidget {
  const _MedicationDescription({
    required this.nameField,
    required this.typeField,
    required this.descriptionField,
    required this.sideEffectsField,
  });

  final String nameField;
  final String typeField;
  final String descriptionField;
  final String sideEffectsField;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.fromLTRB(5.0, 0.0, 0.0, 0.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: <Widget>[
          Text(
            'name: $nameField',
            style: const TextStyle(fontWeight: FontWeight.w500, fontSize: 14.0),
          ),
          const Padding(padding: EdgeInsets.symmetric(vertical: 2.0)),
          Text(
            'description: $descriptionField',
            style: const TextStyle(fontWeight: FontWeight.w500, fontSize: 14.0),
          ),
          const Padding(padding: EdgeInsets.symmetric(vertical: 2.0)),
          Text('Type: $typeField', style: const TextStyle(fontSize: 10.0)),
          const Padding(padding: EdgeInsets.symmetric(vertical: 1.0)),
          Text('sideEffects: $sideEffectsField', style: const TextStyle(fontSize: 10.0)),
        ],
      ),
    );
  }
}*/
