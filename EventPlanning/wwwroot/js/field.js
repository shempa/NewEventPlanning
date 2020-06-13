


function addField() {   

    let str=$('table').append($('<tr class="DinamicField">').append(
            '<td><input class="FieldName" name="FieldName" id="name" type="text"/></td>',
       '<td><input class="FieldValue" name="FieldValue" type="text"/></td>'            
    ));

};

function delField() {
    let td = $('#name').parent();
    let str = td.parent();
    str.remove();
};

function saveField() {
    var fields=[];
    $('.DinamicField').each(function (i, values) {
        let namen = $(".FieldName").filter("input"); 
        let value = $(".FieldValue").filter("input");

        let id = $(".EventId").filter("input");
        
        let FieldName = $(namen[i]).val();
        let FieldValue = $(value[i]).val();

        let EventId = $(id).val();

        var field = { FieldName: FieldName, FieldValue: FieldValue, EventId:EventId};
        fields.push(field);

        debugger;
    });
    $.post('AddField', { fields: fields });
    debugger;
    
};








/*


function saveField() {

    var fields=[];

    $('.DinamicField').each(function (i, values) {
        let namen = $(".FieldName").filter("input");
        let value = $(".FieldValue").filter("input");
        let FieldName = $(namen[i]).val();
        let FieldValue = $(value[i]).val();

        var field = { FieldName: FieldName, FieldValue: FieldValue };
        fields.push(field);

    });

    $.post('SavField', { fields: fields }
    );



    debugger;

};







function delField() {
    $('.FieldValue').remove();
    $('.FieldName').remove();



$('input').remove();

};


 
*/