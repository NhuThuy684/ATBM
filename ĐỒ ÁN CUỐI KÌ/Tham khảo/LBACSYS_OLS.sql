execute sa_sysdba.create_policy(policy_name => 'CHINHSACH', column_name => 'COT');

EXECUTE sa_components.create_level (policy_name => 'CHINHSACH', long_name => 'THONGTHUONG', short_name => 'TT', level_num => 1000);
EXECUTE sa_components.create_level (policy_name => 'CHINHSACH', long_name => 'GIOIHAN', short_name => 'GH', level_num => 2000);
EXECUTE sa_components.create_level (policy_name => 'CHINHSACH', long_name => 'BIMAT', short_name => 'BM', level_num => 3000);
EXECUTE sa_components.create_compartment (policy_name => 'CHINHSACH', long_name => 'THUOC', short_name => 'TH', comp_num =>100);
EXECUTE sa_components.create_compartment (policy_name => 'CHINHSACH', long_name => 'DICHVU', short_name => 'DV', comp_num =>200);
EXECUTE sa_components.create_group (policy_name => 'CHINHSACH', long_name => 'BACNAM', short_name => 'BN', group_num => 10);
EXECUTE sa_components.create_group (policy_name => 'CHINHSACH', long_name => 'MIENBAC', short_name => 'MB', group_num => 30, parent_name => 'BN');
EXECUTE sa_components.create_group (policy_name => 'CHINHSACH', long_name => 'MIENNAM', short_name => 'MN', group_num => 50, parent_name => 'BN');

EXECUTE sa_label_admin.create_label (policy_name => 'CHINHSACH', label_tag =>1000, label_value => 'TT');
EXECUTE sa_label_admin.create_label (policy_name => 'CHINHSACH', label_tag =>2000, label_value => 'GH');
EXECUTE sa_label_admin.create_label (policy_name => 'CHINHSACH', label_tag =>1100, label_value => 'TT:TH');
EXECUTE sa_label_admin.create_label (policy_name => 'CHINHSACH', label_tag =>1200, label_value => 'TT:DV');
EXECUTE sa_label_admin.create_label (policy_name => 'CHINHSACH', label_tag =>3100, label_value => 'BM:TH');
EXECUTE sa_label_admin.create_label (policy_name => 'CHINHSACH', label_tag =>1210, label_value => 'TT:DV:BN');
EXECUTE sa_label_admin.create_label (policy_name => 'CHINHSACH', label_tag =>1350, label_value => 'TT:TH,DV:MN');

begin
sa_policy_admin.apply_table_policy(
policy_name => 'CHINHSACH', schema_name => 'QLBV', table_name => 'THONGBAO', table_options => 'NO_CONTROL');
end;
-- BACSI NV1512014
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'BACSI',
  max_read_label => 'GH:TH,DV:BN',
  max_write_label => 'GH:TH,DV:BN',
  min_write_label => 'TT',
  def_label => 'GH:TH,DV',
  row_label => 'GH:TH,DV');
END;
-- quan ly chuyen mon NV1512003
BEGIN sa_user_admin.set_user_privs(
  policy_name => 'CHINHSACH',
  user_name => 'QLCHUYENMON',
  PRIVILEGES => 'READ');
END;
-- quan ly benh vien co toan quyen tren table thong bao
BEGIN sa_user_admin.set_user_privs(
  policy_name => 'CHINHSACH',
  user_name => 'QLBV',
  PRIVILEGES => 'FULL');
END;
-- Nhan vien ky thuat NV1512019
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'KYTHUATVIEN',
  max_read_label => 'TT:DV',
  max_write_label => 'TT:DV',
  min_write_label => 'TT'
);
END;
-- Nhan vien phong thuoc NV1512014/mien bac
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'NV1512022',
  max_read_label => 'TT:TH:MB',
  max_write_label => 'TT:TH:MB',
  min_write_label => 'TT'
);
END;
-- Nhan vien phong thuoc NV1512014/ bac nam
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'NV1512023',
  max_read_label => 'TT:TH:BN',
  max_write_label => 'TT:TH:BN',
  min_write_label => 'TT'
);
END;
-- tat ca nhan vien 
-- kế toán
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'NV1512025',
  max_read_label => 'TT',
  max_write_label => 'TT',
  min_write_label => 'TT'
);
END;
--nv tài vụ
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'NV1512009',
  max_read_label => 'TT',
  max_write_label => 'TT',
  min_write_label => 'TT'
);
END;
--tiep tân
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'NV1512004',
  max_read_label => 'TT',
  max_write_label => 'TT',
  min_write_label => 'TT'
);
END;
--ql tài vụ
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'NV1512002',
  max_read_label => 'TT',
  max_write_label => 'TT',
  min_write_label => 'TT'
);
END;
--ql chuyên môn
BEGIN sa_user_admin.set_user_labels(
  policy_name => 'CHINHSACH',
  user_name => 'NV15120',
  max_read_label => 'TT',
  max_write_label => 'TT',
  min_write_label => 'TT'
);
END;
BEGIN
sa_policy_admin.remove_table_policy
(policy_name => 'CHINHSACH',
schema_name => 'QLBV',
table_name => 'THONGBAO');
sa_policy_admin.apply_table_policy
(policy_name => 'CHINHSACH',
schema_name => 'QLBV',
table_name => 'THONGBAO',
table_options =>
'READ_CONTROL,WRITE_CONTROL,CHECK_CONTROL');
END;

UPDATE QLBV.THONGBAO SET COT = char_to_label('CHINHSACH', 'TT');
UPDATE QLBV.THONGBAO SET COT = char_to_label('CHINHSACH', 'TT:TH') WHERE TYP = 'THUOC'; 
UPDATE QLBV.THONGBAO SET COT = char_to_label('CHINHSACH', 'TT:DV') WHERE TYP = 'DICH VU'; 
UPDATE QLBV.THONGBAO SET COT = char_to_label('CHINHSACH', 'GH')WHERE CREATEBY = 'BAC SI';
UPDATE QLBV.THONGBAO SET COT = char_to_label('CHINHSACH', 'BM:TH') WHERE CREATEBY = 'QLCHUYENMON' AND TYP = 'THUOC';
UPDATE QLBV.THONGBAO SET COT = char_to_label('CHINHSACH', 'TT:TH,DV:MN') WHERE REGION = 'MIEN NAM';
