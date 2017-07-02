/**
 * Created by Dustin on 7/2/2017.
 */
import axios from "axios"

const url = "http://localhost:51554/api/titles";

// mock data
export function SearchTitles(title, cb) {
	cb(null,{ titleList:
		[
			{
				titleId: 610,
				titleName: "Casablanca",
				titleNameSortable: "Casablanca",
				titleTypeId: null,
				releaseYear: 1942,
				processedDateTimeUTC: "2013-06-15T02:01:55.153",
			},
			{
				titleId: 2761,
				titleName: "Ben-Hur (Part 1)",
				titleNameSortable: "Ben-Hur (Part 1)",
				titleTypeId: null,
				releaseYear: 1959,
				processedDateTimeUTC: "2013-06-03T08:03:20"
			},
			{
				titleId: 12708,
				titleName: "A Man for All Seasons",
				titleNameSortable: "Man for All Seasons, A",
				titleTypeId: null,
				releaseYear: 1966,
				processedDateTimeUTC: "2013-06-03T08:03:20"
			},
			{
				titleId: 14798,
				titleName: "Cimarron",
				titleNameSortable: "Cimarron",
				titleTypeId: null,
				releaseYear: 1931,
				processedDateTimeUTC: "2013-06-03T08:03:20"
			},
			{
				titleId: 16636,
				titleName: "Annie Hall",
				titleNameSortable: "Annie Hall",
				titleTypeId: null,
				releaseYear: 1977,
				processedDateTimeUTC: "2013-06-22T02:00:57.283"
			},
			{
				titleId: 23093,
				titleName: "Amadeus (Part 1)",
				titleNameSortable: "Amadeus (Part 1)",
				titleTypeId: null,
				releaseYear: 1984,
				processedDateTimeUTC: "2013-07-06T02:00:48.51"
			}
		]});
}


// export function SearchTitles(title, cb) {
// 	return (async ()=> {
// 		axios.get(url)
// 			.then((response) =>{
// 				console.log("Response Data : ", response);
// 				cb(null, response.data.cards);
// 			})
// 			.catch((error) => {
// 				console.log("Error : ", error);
// 				cb(error, null);
// 			});
// 	})();
// }