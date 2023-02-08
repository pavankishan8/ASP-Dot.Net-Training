const url = "http://localhost:56184/api/product"

function onView(id) {
    const tempurl = url + "/" + id;
    $.get(tempurl, (data) => {
        $("#txtid").val(data.ProductId);
        $("#txtname").val(data.ProductName);
        $("#txtprice").val(data.Price);
        $("#txtqty").val(data.Quantity);
        $("#imgdetails").attr("src", "http://localhost:56184/"+ data.ProductImage)
    })
}

function loadRecords()
{
    $("table").find("tr:gt(0)").remove();
    $.get(url, (data) => { for (const value of data)
        {
            const row = `<tr><td>${value.ProductId}</td><td>${value.ProductName}</td><td><a href="#" 
            onclick="onView(${value.ProductId})">View</a></td></tr>`;
            $("table").append(row);
        }
    
    })
}

function updateRecord() {
    let obj = {};
    obj.ProductId = $("#txtid").val()
    obj.ProductName = $("#txtname").val()
    obj.Price = $("#txtprice").val()
    obj.Quantity = $("#txtqty").val()
    let src = $("#imgdetails").attr("src");
    let modified = src.replace("http://localhost:56184/", "");
    alert(modified);
    obj.ProductImage = modified;
    $.ajax({
        'url': url,
        'data': obj,
        'success': function () { loadRecords(); },
        'method': 'PUT'
    });
}

function init(){
    $("a:first").click(loadRecords);
    $("#btnUpdate").click(updateRecord);
}