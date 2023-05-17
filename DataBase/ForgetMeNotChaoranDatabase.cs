//using ForgetMeNotChaoran.Model;
//using SQLite;

//namespace ForgetMeNotChaoran.DataBase
//{
//    public class ForgetMeNotChaoranDatabase
//    {
//        // Declare an object of type SQLiteAsyncConnection and name it Database
//        private SQLiteAsyncConnection _dataBase;

//        private async Task Init()
//        {
//            if (_dataBase is not null)
//                return;

//            _dataBase = new SQLiteAsyncConnection(
//                Constants.DatabasePath,
//                Constants.Flags);
//            await _dataBase.CreateTableAsync<Preference>();
//        }

//        public async Task<int> SavePreference(Preference preference)
//        {
//            await Init();
//            if(preference.Id != 0)
//            {
//                return await _dataBase.UpdateAsync(preference);
//            }
//            else
//            {
//                return await _dataBase.InsertAsync(preference);
//            }
//        }

//        public async Task<List<Preference>> GetPreferences()
//        {
//            await Init();
//            return await _dataBase.Table<Preference>().ToListAsync();
//        }
//    }
//}
