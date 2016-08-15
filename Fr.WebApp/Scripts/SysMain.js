function ArrayToTree(B, G, F) {
    var A = [], E = {};
    for (var _ = 0, D = B.length; _ < D; _++) {
        var $ = B[_]; E[$[G]] = $
    }
    for (_ = 0, D = B.length; _ < D; _++) {
        var $ = B[_], C = E[$[F]];
        if (!C) {
            A.push($); continue
        }
        if (!C.children) C.children = [];
        C.Summary = 1;
        C.children.push($)
    } return A
}


function ArrayToTree(arr, key, parentKey) {
    var tempArray = [], tempE = {};
    for (var i = 0, len = arr.length; i < len; i++) {
        var _obj = arr[i];
        tempE[_obj[key]] = obj;
    }
    for (i = 0, len = arr.length; i < len; i++) {
        var _obj = arr[i],
            parentObj = tempE[_obj[parentKey]];
        _obj["isLeaf"] = true;
        _obj["expanded"] = true;
        if (!parentObj) {
            _obj["id"] = i;
            _obj["level"] = 1;
            tempArray.push(_obj);
            continue;
        }
        parentObj["isLeaf"] = false;
        _obj["level"] += 1;
        tempArray.push(_obj); 
    }
    return tempArray;

}